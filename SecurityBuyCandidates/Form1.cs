using SecurityBuyCandidates.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityBuyCandidates
{
    public partial class Form1 : Form
    {
        const int MAX_DAYS = 365;
        public Form1()
        {
            InitializeComponent();
        }

        #region Utility Functions
        
        private double WMA(List<vwSecurityHistory> PriceList, int Period = 26, int Offset = 0)
        {
            double p = 0;

            int j = 0;
            int k = Period + Offset;
            for (int i = 0 + Offset; i < k; i++)
            {
                if (PriceList[i].Volume > 0)
                {
                    p += PriceList[i].ClosingPrice * (Period - j);
                    j++;
                }
                else
                {
                    if (k < MAX_DAYS)
                    {
                        k++;
                    }
                }
            }

            p = p / (Period * (Period + 1) / 2);

            return p;
        }
        private double SMA(List<vwSecurityHistory> PriceList, int Period = 20, int Offset = 0)
        {
            double p = 0;

            int j = 0;
            int k = Period + Offset;
            for (int i = 0 + Offset; i < k; i++)
            {
                if (PriceList[i].Volume > 0)
                {
                    p += PriceList[i].ClosingPrice;
                    j++;
                }
                else
                {
                    if (k < MAX_DAYS)
                    {
                        k++;
                    }
                }
            }

            p = p / Period ;

            return p;
        }
        
        private double Sadeghi85(List<vwSecurityHistory> PriceList, int Period, int Offset = 0)
        {

            double[] p = new double[Period + Offset];

            int trend, nexttrend;
            double hh, ll, maxl, minh, lma, hma;

            nexttrend = 0;
            trend = 0;
            maxl = 0;
            minh = 9999999;

            for (int bar = Period + Offset - 1; bar >= 0 + Offset; bar--)
            {
                hh = Math.Max(PriceList[bar].HighestPrice, PriceList[bar + 1].HighestPrice);
                ll = Math.Min(PriceList[bar].LowestPrice, PriceList[bar + 1].LowestPrice);
                lma = (double)(PriceList[bar].LowestPrice + PriceList[bar + 1].LowestPrice) / 2;
                hma = (double)(PriceList[bar].HighestPrice + PriceList[bar + 1].HighestPrice) / 2;
                
                //---
                if (nexttrend == 1)
                {
                    maxl = Math.Max(ll, maxl);

                    if (hma < maxl && PriceList[bar].ClosingPrice < PriceList[bar + 1].LowestPrice)
                    {
                        trend = 1;
                        nexttrend = 0;
                        minh = hh;
                    }
                }
                //---
                if (nexttrend == 0)
                {
                    minh = Math.Min(hh, minh);

                    if (lma > minh && PriceList[bar].ClosingPrice > PriceList[bar + 1].HighestPrice)
                    {
                        trend = 0;
                        nexttrend = 1;
                        maxl = ll;
                    }
                }
                //---
                if (trend == 0)
                {
                    p[bar] = 0.80 * PriceList[bar].ClosingPrice;
                }
                if (trend == 1)
                {
                    p[bar] = 1.2 * PriceList[bar].ClosingPrice;
                }
                //---

            }


            return p[Offset];
        }

        private Growth CurrentGrowth(List<vwSecurityHistory> PriceList)
        {
            double p = 0;

            int k = 1;
            int l = 0;
            double firstPrice = PriceList[0].ClosingPrice;
            double lastPrice = PriceList[0].ClosingPrice;

            //if (Security.SecurityID== 2440)
            {
                for (int j = 0; j < PriceList.Count - nudWMA.Value; j++)
                {
                    //double wma = WMA(PriceList, (int)nudWMA.Value, j);
                    double wma = Sadeghi85(PriceList, (int)nudWMA.Value, j);

                    l = j;

                    if (wma <= PriceList[j].ClosingPrice)
                    {
                        if (k == 1)
                        {
                            lastPrice = (double)PriceList[j].ClosingPrice;
                        }

                        k++;
                    }
                    else
                    {
                        firstPrice = (double)PriceList[j].ClosingPrice;

                        break;
                    }
                }

                p = ((lastPrice - firstPrice) / firstPrice) * 100;
            }

            return new Growth {Days = k, Percent = p };
        }

        public class Growth
        {
            public double Percent { get; set; }
            public int Days { get; set; }
        }
        #endregion

        #region BuyCandidates
        private async void btnAnalyse_Click(object sender, EventArgs e)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                dataGridView1.Invoke(new Action(
                             () =>
                             {
                                 dataGridView1.Rows.Clear();
                             }
                    ));

                progressBar1.Value = 0;

                //List<int> tmp = new List<int>() { 2236, 2148, 2271, 2420, 2520 };
                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => tmp.Contains(x.SecurityID)).OrderBy(x => x.SecurityName).ToList();

                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).OrderBy(x => x.SecurityName).ToList();
                List<Security> Securities = GoodSecurities();

                progressBar1.Value = 0;

                for (int i = 0; i < Securities.Count; i++)
                {
                    Security Security = Securities[i];

                    await Task.Run(() => AnalyseSingle(Security));

                    progressBar1.Value = (int)(((i + 1) * 100) / Securities.Count);
                }

                dataGridView1.Invoke(new Action(
                             () =>
                             {
                                 dataGridView1.Sort(dataGridView1.Columns["AvgGrowthPercent"], ListSortDirection.Descending);

                             }
                    ));
                

                Console.WriteLine(string.Format("Done.\n"));


                //await Task.Run(() => progressBar1.Invoke(new Action(
                //             () =>
                //             {
                //                 progressBar1.Value = 0;
                //             }
                //    )));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AnalyseSingle(Security Security)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                DateTime Date = dtpDate.Value.Date;

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && x.Date <= Date).OrderByDescending(x => x.Date).Take(MAX_DAYS).ToList();

                DateTime firstDate = Date.AddDays(1);
                DateTime lastDate = Date.AddDays(31);
                int firstPrice = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && x.Date <= firstDate).OrderByDescending(x => x.Date).Take(1).First().ClosingPrice;
                int lastPrice = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && x.Date <= lastDate).OrderByDescending(x => x.Date).Take(1).First().ClosingPrice;
                double OneMonthProfit = Math.Round(((double)(lastPrice - firstPrice) / firstPrice) * 100, 2);

                //double wma = WMA(PriceList);
                //double percent = 0;
                //double close = (double)PriceList[0].ClosingPrice;

                //percent = (close - wma) / wma;

                //if (percent >= -0.08 && percent <= 0.2 && EFI(PriceList) > 0)

                double BuyerStrength = 0;
                try
                {
                    BuyerStrength = Math.Round(((double)PriceList[0].NaturalBuyVolume / (double)PriceList[0].NaturalBuyCount) / ((double)PriceList[0].NaturalSellVolume / (double)PriceList[0].NaturalSellCount), 2);
                }
                catch (Exception ex)
                {

                }

                Growth Growth = CurrentGrowth(PriceList);

                if ((Growth.Percent / (double)Growth.Days > 1.0) && ((Growth.Days >= nudMinGrowthDays.Value) && (Growth.Days <= nudMaxGrowthDays.Value)) && ((Growth.Percent >= (double)nudMinGrowthPercent.Value) && (Growth.Percent <= (double)nudMaxGrowthPercent.Value)))
                {
                    dataGridView1.Invoke(new Action(
                             () =>
                            {
                                var index = dataGridView1.Rows.Add();
                                dataGridView1.Rows[index].Cells["SecurityName"].Value = Security.SecurityName;
                                dataGridView1.Rows[index].Cells["SecurityDescription"].Value = Security.SecurityDescription;
                                dataGridView1.Rows[index].Cells["MarketType"].Value = Security.MarketType;
                                dataGridView1.Rows[index].Cells["SecurityGroupTitle"].Value = Security.SecurityGroupTitle;
                                dataGridView1.Rows[index].Cells["Comment"].Value = Security.Comment + string.Format(" Current Growth Percent: {0}, Current Growth Days: {1}.", Math.Round(Growth.Percent, 2), Growth.Days);
                                dataGridView1.Rows[index].Cells["AvgGrowthPercent"].Value = Math.Round(Growth.Percent / Growth.Days, 2);
                                dataGridView1.Rows[index].Cells["OneMonthProfit"].Value = OneMonthProfit;

                                dataGridView1.Rows[index].Cells["BuyerStrength"].Value = BuyerStrength;
                            }
                    ));



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private List<int> GoodSecurityGroups()
        {
            DB_BourseEntities ctx = new DB_BourseEntities();

            List<int> GoodSecurityGroupIDs = new List<int> { 45,44,40,42,34,27,24,26,8,11,17,35,15,30,38,18,3,23,1,33,47,43,31,  16,22,28,2,5 };

            //List<SecurityGroup> GoodSecurityGroups = ctx.tblSecurityGroup.Where(x => GoodSecurityGroupIDs.Contains(x.SecurityGroupID)).Select(x => new SecurityGroup { SecurityGroupID = x.SecurityGroupID, SecurityGroupTitle = x.SecurityGroupTitle }).ToList();

            return GoodSecurityGroupIDs;
        }

        private List<Security> GoodSecurities()
        {
            List<Security> GoodSecurities = new List<Security>();

            List<int> GoodSecurityGroupsList = GoodSecurityGroups();

            progressBar1.Value = 0;

            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                bool flag = false;

                //List<int> tmp = new List<int>() { 2236, 2148, 2271, 2420, 2520 };
                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => tmp.Contains(x.SecurityID)).OrderBy(x => x.SecurityName).ToList();

                List<Security> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6 && x.EPS > 0 && x.SharesCount >= 180000000 && GoodSecurityGroupsList.Contains(x.SecurityGroupID)).Select(x => new Security {SecurityGroupID = x.SecurityGroupID, SecurityDescription=x.SecurityDescription,MarketType=x.MarketType,SecurityGroupTitle=x.SecurityGroupTitle,SecurityName=x.SecurityName, SecurityID=x.SecurityID }).OrderBy(x => x.SecurityName).ToList();

                for (int i = 0; i < Securities.Count; i++)
                {
                    progressBar1.Value = (int)(((i + 1) * 100) / Securities.Count);

                    Security Security = Securities[i];

                    DateTime Date = dtpDate.Value.Date;

                    List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && x.Date <= Date).OrderByDescending(x => x.Date).Take(MAX_DAYS).ToList();

                    int k = 1;
                    int l = 0;
                    double firstPrice = 0;
                    double lastPrice = 0;

                    //if (Security.SecurityID == 2182)
                    {
                        for (int j = 0; j < PriceList.Count - nudWMA.Value; j++)
                        {
                            //double wma = WMA(PriceList, (int)nudWMA.Value, j);
                            double wma = Sadeghi85(PriceList, (int)nudWMA.Value, j);

                            l = j;

                            if (wma <= PriceList[j].ClosingPrice)
                            {
                                if (k == 1)
                                {
                                    lastPrice = (double)PriceList[j].ClosingPrice;
                                }

                                k++;
                            }
                            else
                            {
                                firstPrice = (double)PriceList[j].ClosingPrice;

                                //if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k >= 15) && (k == l + 1))
                                //if ((k >= 15) && (k == l + 1))
                                //{
                                //    flag = false;
                                //    break;
                                //}
                                //else if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k >= nudMinGrowth.Value))
                                //else
                                if (((((lastPrice - firstPrice) / firstPrice) * 100) / (double)k > 1.0) && (k >= 20) && (l + 1 > k))
                                //if ((k >= 20) && (l + 1 > k))
                                {
                                    flag = true;
                                    break;
                                }
                                //else if ((k > 10) && (k < 20) && (l + 1 > k))
                                //{
                                //    flag = false;
                                //    break;
                                //}


                                k = 1;
                                
                            }

                        }
                    }


                    if (flag)
                    {
                        Growth Growth = CurrentGrowth(PriceList);

                        //if ((k >= 20) && (l + 1 - k >= nudMinCorrection.Value)) //&& (l + 1 - k <= nudMaxCorrection.Value))
                        //if ((k >= 20) && (l + 1 - k >= 20 || l + 1 - k <= 10))
                        if ((k >= 20) && (l + 1 - k - Growth.Days >= 20))
                        {
                            //Security.Comment = string.Format("Growth for {0} days, Correction for {1} days, over {2} days.", k, l + 1 - k, l + 1);
                            GoodSecurities.Add(Security);
                        }
                    }

                    flag = false;

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            return GoodSecurities;
        }

        #endregion

        #region Group Rank
        private async void btnAnalyse2_Click(object sender, EventArgs e)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                dataGridView2.Invoke(new Action(
                             () =>
                             {
                                 dataGridView2.Rows.Clear();
                             }
                    ));

                //progressBar1.Value = 0;

                //List<int> tmp = new List<int>() { 2236, 2148, 2271, 2420, 2520 };
                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => tmp.Contains(x.SecurityID)).OrderBy(x => x.SecurityName).ToList();



                List<Security> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).OrderBy(x => x.SecurityName).Select(x => new Security() {SecurityID=x.SecurityID,SecurityGroupTitle=x.SecurityGroupTitle,SecurityGroupID=x.SecurityGroupID, cycle=0 }).ToList();

                progressBar2.Value = 0;

                for (int i = 0; i < Securities.Count; i++)
                {
                    Security Security = Securities[i];

                    int cycle = await Task.Run(() => AnalyseSingle2(Security));
                    Securities[i].cycle = cycle;

                    progressBar2.Value = (int)(((i + 1) * 100) / Securities.Count);


                }


                List<SecurityGroup> SecurityGroups = Securities.GroupBy(x => new { x.SecurityGroupID, x.SecurityGroupTitle }).Select(x => new SecurityGroup() { SecurityGroupID = x.Key.SecurityGroupID,SecurityGroupTitle=x.Key.SecurityGroupTitle, AverageCycle = x.Average(z => z.cycle) }).OrderByDescending(x => x.AverageCycle).ToList();

                for (int i = 0; i < SecurityGroups.Count; i++)
                //foreach (SecurityGroup SecurityGroup in SecurityGroups)
                {
                    dataGridView2.Invoke(new Action(
                             () =>
                             {
                                 var index = dataGridView2.Rows.Add();

                                 dataGridView2.Rows[index].Cells["Index2"].Value = i+1;
                                 dataGridView2.Rows[index].Cells["SecurityGroupID"].Value = SecurityGroups[i].SecurityGroupID;
                                 dataGridView2.Rows[index].Cells["SecurityGroupTitle2"].Value = SecurityGroups[i].SecurityGroupTitle;
                                 dataGridView2.Rows[index].Cells["AverageCycle"].Value = Math.Round(SecurityGroups[i].AverageCycle, 2);
                             }
                    ));
                }


                dataGridView2.Invoke(new Action(
                             () =>
                             {

                                 dataGridView2.Sort(dataGridView2.Columns["AverageCycle"], ListSortDirection.Descending);
                             }
                    ));


                Console.WriteLine(string.Format("Done.\n"));


                //await Task.Run(() => progressBar1.Invoke(new Action(
                //             () =>
                //             {
                //                 progressBar1.Value = 0;
                //             }
                //    )));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private async Task<int> AnalyseSingle2(Security Security)
        {
            int cycle = 0;

            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                DateTime StartDate = dtpStartDate2.Value.Date;
                DateTime EndDate = dtpEndDate2.Value.Date;

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && (x.Date <= EndDate && x.Date >= StartDate)).OrderByDescending(x => x.Date).ToList();



                int k = 1;
                int l = 0;
                double firstPrice = 0;
                double lastPrice = 0;


                for (int j = 0; j < PriceList.Count - 26; j++)
                {
                    double wma = WMA(PriceList, 26, j);

                    l = j;

                    if (wma <= PriceList[j].ClosingPrice)
                    {
                        if (k == 1)
                        {
                            lastPrice = (double)PriceList[j].ClosingPrice;
                        }

                        k++;
                    }
                    else
                    {
                        firstPrice = (double)PriceList[j].ClosingPrice;

                        if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k > 10) && (k == l + 1))
                        {
                            cycle++;
                        }
                        else if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k >= nudMinGrowth2.Value))
                        {
                            cycle++;
                        }
                       
                        k = 1;
                        
                    }

                }

                {
                    firstPrice = (double)PriceList[PriceList.Count - 1].ClosingPrice;
                    if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k >= nudMinGrowth2.Value))
                    {
                        cycle++;
                    }
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cycle;
        }

        public class SecurityGroup
        {
            public int SecurityGroupID { get; set; }
            public string SecurityGroupTitle { get; set; }
            public double AverageCycle { get; set; }
        }

        public class Security
        {
            public int SecurityID { get; set; }
            public int SecurityGroupID { get; set; }
            public string SecurityGroupTitle { get; set; }
            public int cycle { get; set; }

            public string SecurityName { get; set; }
            public string SecurityDescription { get; set; }
            public string MarketType { get; set; }
            public string Comment { get; set; }

        }

        #endregion

       

        
    }
}
