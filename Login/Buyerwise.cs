using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Buyerwise : Form
    {
        public string fromDate = "";
        public string toDate = "";
        public string Plant = "";

        public Buyerwise()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            Plant = plantComboBox.SelectedItem.ToString();
            try
            {
                BuyerWiseSampleSummerForBuyerwise(fromDate, toDate, Plant);
                
            }

            catch (Exception ex)
            {

            }
        }

        public void BuyerWiseSampleSummerForBuyerwise(string FromDate, string ToDate,string Plant)
        {
            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.GetBuyerWiseProduction(FromDate, ToDate, Plant);
                dataBind.DataSource = dt;
                buyerWisedataGridView.DataSource = dataBind;
            }
            catch (Exception ex)
            {


            }
        }

        private void excellButton_Click(object sender, EventArgs e)
        {

            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            Plant = plantComboBox.SelectedItem.ToString();

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.GetBuyerWiseProduction(fromDate, toDate, Plant);
            dataBind.DataSource = dt;
            buyerWisedataGridView.DataSource = dataBind;

            if (buyerWisedataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Buyer_Wise_Repports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("BUYER WISE SAMPLE SUMMERY");
                    wr.WriteLine();
                    wr.WriteLine();
                    wr.WriteLine();



                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                    }
                    wr.WriteLine();
                    for (int i = 0; i < (dt.Rows.Count); i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Rows[i][j] != null)
                            {
                                wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }
                    wr.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }
}
