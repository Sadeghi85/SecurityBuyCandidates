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
        public Form1()
        {
            InitializeComponent();
        }

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
                List<vwSecurity> Securities = GoodSecurities();

                for (int i = 0; i < Securities.Count; i++)
                {
                    vwSecurity Security = Securities[i];

                    await Task.Run(() => AnalyseSingle(Security));


                    progressBar1.Value = (int)(((i + 1) * 100) / Securities.Count);


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

        private double EFI(List<vwSecurityHistory> PriceList, int Period = 13)
        {
            List<double> e = new List<double>();


            int k = Period;

            for (int i = 0; i < k; i++)
            {
                if (PriceList[i].Volume > 0)
                {
                    e.Add((PriceList[i].ClosingPrice - PriceList[i + 1].ClosingPrice) * PriceList[i].Volume);
                }
                else
                {
                    if (k < 365)
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

        private void AnalyseSingle(vwSecurity Security)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID).OrderByDescending(x => x.Date).Take(365).ToList();

                double wma = WMA(PriceList);
                double percent = 0;
                double close = (double)PriceList[0].ClosingPrice;



                percent = (close - wma) / wma;


                if (percent >= -0.08 && percent <= 0.2 && EFI(PriceList) > 0)
                {
                    dataGridView1.Invoke(new Action(
                             () =>
                            {
                                var index = dataGridView1.Rows.Add();
                                dataGridView1.Rows[index].Cells["SecurityName"].Value = Security.SecurityName;
                                dataGridView1.Rows[index].Cells["SecurityDescription"].Value = Security.SecurityDescription;
                                dataGridView1.Rows[index].Cells["MarketType"].Value = Security.MarketType;
                                dataGridView1.Rows[index].Cells["SecurityGroupTitle"].Value = Security.SecurityGroupTitle;
                                dataGridView1.Rows[index].Cells["Status"].Value = Security.Status;
                                dataGridView1.Rows[index].Cells["StatusDescription"].Value = Security.StatusDescription + string.Format(" Distance to current wma: {0} percent.", Math.Round(percent * 100, 2));
                            }
                    ));



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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
                    if (k < 365)
                    {
                        k++;
                    }
                }
            }

            p = p / (Period * (Period + 1) / 2);

            return p;
        }

        private List<vwSecurity> GoodSecurities()
        {
            List<vwSecurity> GoodSecurities = new List<vwSecurity>();

            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                bool flag = false;

                //List<int> tmp = new List<int>() { 2236, 2148, 2271, 2420, 2520 };
                //List<vwSecurity> Securities = ctx.vwSecurity.Where(x => tmp.Contains(x.SecurityID)).OrderBy(x => x.SecurityName).ToList();

                List<vwSecurity> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).OrderBy(x => x.SecurityName).ToList();

                for (int i = 0; i < Securities.Count; i++)
                {
                    vwSecurity Security = Securities[i];

                    List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID).OrderByDescending(x => x.Date).Take(365).ToList();

                    int k = 1;
                    int l = 0;
                    double firstPrice = 0;
                    double lastPrice = 0;

                    //if (Security.SecurityID== 2413)
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

                                if ((((lastPrice - firstPrice) / firstPrice) * 100) / k >= 1 && k >= 10)
                                {
                                    flag = true;
                                    break;
                                }
                                else
                                {
                                    k = 1;
                                }

                                //if ( k < nudGrowth.Value)
                                //{
                                //    k = 0;
                                //}
                                //else
                                //{
                                //    break;
                                //}

                            }

                        }
                    }


                    if (flag)
                    {
                        if (k >= nudGrowth.Value && l - k >= nudMinCorrection.Value && l - k <= nudMaxCorrection.Value)
                        {
                            Security.StatusDescription = string.Format("Growth for {0} days, Correction for {1} days, over {2} days.", k, l + 1 - k, l + 1);
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

        private async void button1_Click(object sender, EventArgs e)
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

                List<vwSecurity> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).OrderBy(x => x.SecurityName).ToList();

                for (int i = 0; i < Securities.Count; i++)
                {
                    vwSecurity Security = Securities[i];

                    await Task.Run(() => AnalyseGoodSecuritySingle(Security));


                    progressBar1.Value = (int)(((i + 1) * 100) / Securities.Count);


                }

                Console.WriteLine(string.Format("Done.\n"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AnalyseGoodSecuritySingle(vwSecurity Security)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                bool result = false;

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID).OrderByDescending(x => x.Date).Take(365).ToList();

                int k = 0;

                for (int i = 0; i < PriceList.Count - 26; i++)
                {
                    double wma = WMA(PriceList, 26, i);


                    if (wma <= PriceList[i].ClosingPrice)
                    {
                        k++;
                    }
                    else
                    {
                        k = 0;
                    }

                    if (k > 25 && i < 50)
                    {
                        dataGridView1.Invoke(new Action(
                             () =>
                             {
                                 var index = dataGridView1.Rows.Add();
                                 dataGridView1.Rows[index].Cells["SecurityName"].Value = Security.SecurityName;
                                 dataGridView1.Rows[index].Cells["SecurityDescription"].Value = Security.SecurityDescription;
                                 dataGridView1.Rows[index].Cells["MarketType"].Value = Security.MarketType;
                                 dataGridView1.Rows[index].Cells["SecurityGroupTitle"].Value = Security.SecurityGroupTitle;
                                 dataGridView1.Rows[index].Cells["Status"].Value = Security.Status;
                                 dataGridView1.Rows[index].Cells["StatusDescription"].Value = Security.StatusDescription;
                             }
                        ));

                        break;
                    }
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
