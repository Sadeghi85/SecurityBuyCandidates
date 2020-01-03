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
        private double EFI(List<vwSecurityHistory> PriceList, int Period = 13, int Offset = 0)
        {
            List<double> e = new List<double>();

            int k = Period + Offset;

            for (int i = 0 + Offset; i < k; i++)
            {
                if (PriceList[i].Volume > 0)
                {
                    e.Add((PriceList[i].ClosingPrice - PriceList[i + 1].ClosingPrice) * PriceList[i].Volume);
                }
                else
                {
                    if (k < MAX_DAYS)
                    {
                        k++;
                    }
                }
            }

            double p = 0;

            if (e.Count == Period)
            {
                for (int i = 0; i < Period; i++)
                {
                    p += e[i] * (Period - i);

                }

                p = p / (Period * (Period + 1) / 2);

            }

            return p;
        }
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
        private double SD(List<vwSecurityHistory> PriceList, int Period = 20, int Offset = 0)
        {
            double p = 0;

            double sma = SMA(PriceList, Period, Offset);



            int j = 0;
            int k = Period + Offset;
            for (int i = 0 + Offset; i < k; i++)
            {
                if (PriceList[i].Volume > 0)
                {
                    p += Math.Pow((PriceList[i].ClosingPrice - sma), 2);
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

            p = p / (Period - 1);
            p = Math.Pow(p, 0.5);

            return p;
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

                if ((Growth.Percent / Growth.Days >= 2.0) && ((Growth.Days - 1 >= nudMinGrowth.Value) && (Growth.Days - 1 <= 15)) && ((Growth.Percent >= (double)nudMinGrowthPercent.Value) && (Growth.Percent <= (double)nudMaxGrowthPercent.Value)))
                //if (((Growth.Days >= nudMinGrowth.Value) && (Growth.Days <= 15)) && ((Growth.Percent >= (double)nudMinGrowthPercent.Value) && (Growth.Percent <= (double)nudMaxGrowthPercent.Value)))
                {
                    dataGridView1.Invoke(new Action(
                             () =>
                            {
                                var index = dataGridView1.Rows.Add();
                                dataGridView1.Rows[index].Cells["SecurityName"].Value = Security.SecurityName;
                                dataGridView1.Rows[index].Cells["SecurityDescription"].Value = Security.SecurityDescription;
                                dataGridView1.Rows[index].Cells["MarketType"].Value = Security.MarketType;
                                dataGridView1.Rows[index].Cells["SecurityGroupTitle"].Value = Security.SecurityGroupTitle;
                                dataGridView1.Rows[index].Cells["Comment"].Value = Security.Comment + string.Format(" Current Growth Percent: {0}, Current Growth Days: {1}.", Math.Round(Growth.Percent, 2), Growth.Days - 1);
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

            List<int> GoodSecurityGroupIDs = new List<int> { 45,44,40,42,34,27,24,26,8,11,17,35,15,30,38,18,3,23,1,33,47,43 };

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

                List<Security> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6 && GoodSecurityGroupsList.Contains(x.SecurityGroupID)).Select(x => new Security {SecurityGroupID = x.SecurityGroupID, SecurityDescription=x.SecurityDescription,MarketType=x.MarketType,SecurityGroupTitle=x.SecurityGroupTitle,SecurityName=x.SecurityName, SecurityID=x.SecurityID }).OrderBy(x => x.SecurityName).ToList();

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

                    //if (Security.SecurityID== 2312)
                    {
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

                                //if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k >= 15) && (k == l + 1))
                                //if ((k >= 15) && (k == l + 1))
                                //{
                                //    flag = false;
                                //    break;
                                //}
                                //else if ((((lastPrice - firstPrice) / firstPrice) * 100) > 10 && (k >= nudMinGrowth.Value))
                                //else
                                if ((k >= 20) && (l + 1 > k))
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
                        //if ((k >= 20) && (l + 1 - k >= nudMinCorrection.Value)) //&& (l + 1 - k <= nudMaxCorrection.Value))
                        if ((k >= 20) && (l + 1 - k >= 20 || l + 1 - k <= 10))
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

        #region Standard Deviation
        private async void btnAnalyseSD_Click(object sender, EventArgs e)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                dataGridView3.Invoke(new Action(
                             () =>
                             {
                                 dataGridView3.Rows.Clear();
                             }
                    ));

                progressBar3.Value = 0;

                //List<int> tmp = new List<int>() { 2236, 2148, 2271, 2420, 2520 };
                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => tmp.Contains(x.SecurityID)).OrderBy(x => x.SecurityName).ToList();

                List<Security> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).Select(x => new Security { SecurityDescription = x.SecurityDescription, MarketType = x.MarketType, SecurityGroupTitle = x.SecurityGroupTitle, SecurityName = x.SecurityName, SecurityID = x.SecurityID }).OrderBy(x => x.SecurityName).ToList();
                

                progressBar3.Value = 0;

                for (int i = 0; i < Securities.Count; i++)
                {
                    Security Security = Securities[i];

                    await Task.Run(() => AnalyseSingleSD(Security));


                    progressBar3.Value = (int)(((i + 1) * 100) / Securities.Count);


                }

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

        private void AnalyseSingleSD(Security Security)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                DateTime Date = dtpDate3.Value.Date;

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && x.Date <= Date).OrderByDescending(x => x.Date).Take(MAX_DAYS).ToList();
                
                double days = (double)nudDays3.Value;
                bool flag = true;

                for (int i = 0; i < days; i++)
                {
                    double sd = SD(PriceList, 20, i);
                    double percent = (sd / PriceList[i].ClosingPrice) * 100;
                    
                    if (!(percent <= (double)nudPercent3.Value))
                    {
                        flag = false;
                    }
                }
                
                if (flag)
                {
                    dataGridView3.Invoke(new Action(
                             () =>
                             {
                                 var index = dataGridView3.Rows.Add();
                                 dataGridView3.Rows[index].Cells["SecurityName3"].Value = Security.SecurityName;
                                 dataGridView3.Rows[index].Cells["SecurityDescription3"].Value = Security.SecurityDescription;
                                 dataGridView3.Rows[index].Cells["MarketType3"].Value = Security.MarketType;
                                 dataGridView3.Rows[index].Cells["SecurityGroupTitle3"].Value = Security.SecurityGroupTitle;
                                 dataGridView3.Rows[index].Cells["Comment3"].Value = string.Format("");
                             }
                    ));



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        #endregion

        #region GrowthPercent
        private async void btnAnalyseGrowthPercent_Click(object sender, EventArgs e)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                dataGridView4.Invoke(new Action(
                             () =>
                             {
                                 dataGridView4.Rows.Clear();
                             }
                    ));

                progressBar4.Value = 0;

                //List<int> tmp = new List<int>() { 2236, 2148, 2271, 2420, 2520 };
                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => tmp.Contains(x.SecurityID)).OrderBy(x => x.SecurityName).ToList();

                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).OrderBy(x => x.SecurityName).ToList();
                //List<Security> Securities = GoodSecurities();
                List<Security> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).Select(x => new Security { SecurityDescription = x.SecurityDescription, MarketType = x.MarketType, SecurityGroupTitle = x.SecurityGroupTitle, SecurityName = x.SecurityName, SecurityID = x.SecurityID }).OrderBy(x => x.SecurityName).ToList();

                progressBar4.Value = 0;

                for (int i = 0; i < Securities.Count; i++)
                {
                    Security Security = Securities[i];

                    await Task.Run(() => AnalyseSingleGrowthPercent(Security));

                    progressBar4.Value = (int)(((i + 1) * 100) / Securities.Count);
                }

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


        private void AnalyseSingleGrowthPercent(Security Security)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                DateTime Date = dtpDate4.Value.Date;

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID && x.Date <= Date).OrderByDescending(x => x.Date).Take(MAX_DAYS).ToList();

                //double wma = WMA(PriceList);
                //double percent = 0;
                //double close = (double)PriceList[0].ClosingPrice;

                //percent = (close - wma) / wma;

                //if (percent >= -0.08 && percent <= 0.2 && EFI(PriceList) > 0)
                Growth Growth = CurrentGrowth(PriceList);

                if (Growth.Percent >= (double)nudMinGrowthPercent4.Value && Growth.Percent <= (double)nudMaxGrowthPercent4.Value)
                {
                    dataGridView4.Invoke(new Action(
                             () =>
                             {
                                 var index = dataGridView4.Rows.Add();
                                 dataGridView4.Rows[index].Cells["SecurityName4"].Value = Security.SecurityName;
                                 dataGridView4.Rows[index].Cells["SecurityDescription4"].Value = Security.SecurityDescription;
                                 dataGridView4.Rows[index].Cells["MarketType4"].Value = Security.MarketType;
                                 dataGridView4.Rows[index].Cells["SecurityGroupTitle4"].Value = Security.SecurityGroupTitle;
                                 dataGridView4.Rows[index].Cells["Comment4"].Value = Security.Comment;
                             }
                    ));



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        #endregion
    }
}
