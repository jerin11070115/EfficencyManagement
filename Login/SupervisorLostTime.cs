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
    public partial class SupervisorLostTime : Form
    {
        public string fromDate = "";
        public string toDate = "";
        string plant = "";
        public SupervisorLostTime()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            plant = plantComboBox.SelectedItem.ToString();
            try
            {
                GetSupervisorSummeryReport(fromDate, toDate, plant);
                
            }

            catch (Exception ex)
            {

            }

        }

        public void GetSupervisorSummeryReport(string FromDate, string ToDate,string Plant)
        {
            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.GetSupervisorSummeryReport(FromDate, ToDate, Plant);
                dataBind.DataSource = dt;
                SupervisordataGridView.DataSource = dataBind;
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

            dt = efficency.GetSupervisorSummeryReport(fromDate, toDate, plant);
            dataBind.DataSource = dt;
            SupervisordataGridView.DataSource = dataBind;
            if (SupervisordataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Supervisor_Wise_Reports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("Supervisor Wise Repports");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
