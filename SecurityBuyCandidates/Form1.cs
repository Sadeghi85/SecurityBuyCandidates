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

                List<vwSecurity> Securities = ctx.vwSecurity.Where(x => x.SecurityTypeID == 6).OrderBy(x => x.SecurityName).ToList();

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

        private void AnalyseSingle(vwSecurity Security)
        {
            try
            {
                DB_BourseEntities ctx = new DB_BourseEntities();

                List<vwSecurityHistory> PriceList = ctx.vwSecurityHistory.Where(x => x.AdjustmentTypeID == 18 && x.SecurityID == Security.SecurityID).OrderByDescending(x => x.Date).Take(365).ToList();

                double wma = WMA(PriceList);
                double percent = 0;
                double close = PriceList[0].ClosingPrice;
                if (wma >= close)
                {
                    percent = (wma - close) / close;
                }
                else
                {
                    percent = (close - wma) / wma;
                }

                if (percent <= .08)
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
    }
}
