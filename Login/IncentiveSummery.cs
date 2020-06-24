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
    public partial class IncentiveSummery : Form
    {
        public string fromDate = "";
        public string toDate = "";
        public string plant = "";
        public IncentiveSummery()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            

            fromDate =Convert.ToString( Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate =Convert.ToString( Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            plant = plantComboBox.SelectedItem.ToString();



            try
            {

                GetIncentiveSummaryReports(fromDate,toDate,plant);
            }
            catch (Exception ex)
            {

            }
            
        }

        public void GetIncentiveSummaryReports(string FromDate,string ToDate, string Plant)
        {

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            try
            {
                dt = efficency.GetIncentiveSummaryReports(fromDate, toDate,Plant);
                dataBind.DataSource = dt;
                incentiveDataGridView.DataSource = dataBind;

            }
            catch (Exception ex)
            {

            }

        }

        private void Excelbutton_Click(object sender, EventArgs e)
        {

            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            plant = plantComboBox.SelectedItem.ToString();
            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.GetIncentiveSummaryReports(fromDate, toDate,plant);
            dataBind.DataSource = dt;
            incentiveDataGridView.DataSource = dataBind;
            if (incentiveDataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Incentive_Summery_Reports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("SAMPLE ROOM MONTHLY INCENTIVE SUMMERY");
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
