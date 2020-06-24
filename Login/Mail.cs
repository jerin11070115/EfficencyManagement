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
    public partial class Mail : Form
    {
        public string fromDate = "";
        public string toDate = "";
        

        public double materialCostR1 = 1735.00;
        public double overHeadCostR1 = 8051.00;
        public double materialCostK2 = 1778.00;
        public double overHeadCostK2 = 9652.00;
        public Mail()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            
            try
            {
                GetMailSummeryReport(fromDate, toDate);
                SampleCostBrakeDownReportForMail(fromDate, toDate, materialCostR1, overHeadCostR1, materialCostK2, overHeadCostK2);
            }

            catch (Exception ex)
            {

            }
        }


        public void GetMailSummeryReport(string FromDate, string ToDate)
        {
            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.GetMailSummeryReport(FromDate, ToDate);
                dataBind.DataSource = dt;
                mailDataGridView.DataSource = dataBind;
            }
            catch (Exception ex)
            {


            }
        }


        public void SampleCostBrakeDownReportForMail(string FromDate, string ToDate, double MaterialCostR1, double OverHeadCostR1, double MaterialCostK2, double OverHeadCostK2)
        {
            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.SampleCostBrakeDownReportForMail(FromDate, ToDate, MaterialCostR1, OverHeadCostR1, MaterialCostK2, OverHeadCostK2);
                dataBind.DataSource = dt;
                sampleCostdataGridView.DataSource = dataBind;
            }
            catch (Exception ex)
            {


            }
        }

        private void SampleMailbutton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.GetMailSummeryReport(fromDate, toDate);
            dataBind.DataSource = dt;
            mailDataGridView.DataSource = dataBind;
            if (mailDataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Mail_Summery_Repports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("Sample Room Efficiency");
                    wr.WriteLine();
                    wr.WriteLine();
                    wr.WriteLine();
                    // Write Columns to excel file
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                    }
                    wr.WriteLine();
                    //write rows to excel file
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
       

        private void Costbrkbutton_Click(object sender, EventArgs e)
        {

            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.SampleCostBrakeDownReportForMail(fromDate, toDate, materialCostR1, overHeadCostR1, materialCostK2, overHeadCostK2);
            dataBind.DataSource = dt;
            sampleCostdataGridView.DataSource = dataBind;
            if (sampleCostdataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Sample_CostBreakdown_Reports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("Sample CostBreakdown Reports");
                    wr.WriteLine();
                    wr.WriteLine();
                    wr.WriteLine();
                    // Write Columns to excel file
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                    }
                    wr.WriteLine();
                    //write rows to excel file
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
