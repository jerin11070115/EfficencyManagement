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

    public partial class CostingSummery : Form
    {
        public string fromDate = "";
        public string toDate = "";
        public double materialCostR1 = 1735.00;
        public double overHeadCostR1 = 8051.00;
        public double materialCostK2 = 1778.00;
        public double overHeadCostK2 = 9652.00;
        public double planCpm = 00.80;
        public CostingSummery()
        {
            InitializeComponent();
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());
            

            

            try
            {
                GetEfficencySummaryReport(fromDate,toDate);
                GetProductionAndOtSummeryReport(fromDate, toDate);
                SampleCostBrakeDownSummeryReport(fromDate, toDate, materialCostR1, overHeadCostR1, materialCostK2, overHeadCostK2, planCpm);
            }

            catch (Exception ex)
            {

            }

        }


        public void GetEfficencySummaryReport(string FromDate, string ToDate)
        {
            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.GetEfficencySummaryReport(FromDate, ToDate);
                dataBind.DataSource = dt;
                efficencyReportDataGridView.DataSource = dataBind;
            }
            catch (Exception ex)
            {


            }

        }

        public void GetProductionAndOtSummeryReport(string FromDate, string ToDate)
        {

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.GetProductionAndOtSummeryReport(FromDate, ToDate);
                dataBind.DataSource = dt;
                productionDataGridView.DataSource = dataBind;
            }
            catch (Exception ex)
            {


            }
        }

        public void SampleCostBrakeDownSummeryReport(string FromDate, string ToDate, double MaterialCostR1, double OverHeadCostR1, double MaterialCostK2, double OverHeadCostK2, double PlanCpm)
        {

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();


            try
            {
                dt = efficency.SampleCostBrakeDownSummeryReport(FromDate, ToDate, MaterialCostR1, OverHeadCostR1, MaterialCostK2, OverHeadCostK2, PlanCpm);
                dataBind.DataSource = dt;
                sampleCostDataGridView.DataSource = dataBind;
            }
            catch (Exception ex)
            {


            }
        }

        private void Excelbutton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.GetEfficencySummaryReport(fromDate, toDate);
            dataBind.DataSource = dt;
            efficencyReportDataGridView.DataSource = dataBind;
            if (efficencyReportDataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Efficiency_Summery_Repports.xls");

                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("Efficiency Summery");
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

        private void Excelbutton1_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.GetProductionAndOtSummeryReport(fromDate, toDate);
            dataBind.DataSource = dt;
            productionDataGridView.DataSource = dataBind;
            if (productionDataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Production_OT_Repports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("Production & OT Summery");
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

        private void SampleCostExcelbutton_Click(object sender, EventArgs e)
        {
            fromDate = Convert.ToString(Convert.ToDateTime(fromDateTimePicker.Text).ToShortDateString());
            toDate = Convert.ToString(Convert.ToDateTime(toDateTimePicker.Text).ToShortDateString());

            EfficencyBLL efficency = new EfficencyBLL();
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();

            dt = efficency.SampleCostBrakeDownSummeryReport(fromDate, toDate, materialCostR1, overHeadCostR1, materialCostK2, overHeadCostK2, planCpm);
            dataBind.DataSource = dt;
            sampleCostDataGridView.DataSource = dataBind;

            if (sampleCostDataGridView.Rows.Count > 0)
            {
                try
                {
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\SampleWise_BrakeDown_Repports.xls");
                    wr.Write("HIRDARAMANI APPARELS BANGLADESH");
                    wr.WriteLine();
                    wr.Write("Unit Cost Status");
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
