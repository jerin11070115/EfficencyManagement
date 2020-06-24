using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.AppCode.Model;

namespace Login.Entry
{
    public partial class Input : Form
    {

        public int Id = 0;
        public int RowId = 0;


        public Input()
        {
            InitializeComponent();
            LoadEfficencyInformation();
            ClearEfficencyInfo();
        }

		private void saveButton_Click(object sender, EventArgs e)
		{
            EfficencyBLL efficencyBLL = new EfficencyBLL();
            EfficencyInput efficency = new EfficencyInput();
            DataTable dt = null;
            int returnValue = 0;
            

            efficency.EfficencyId = Id;
            if (plantComboBox.SelectedItem == "" || plantComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select Plant");
            }
            else
            {

                efficency.Plant = plantComboBox.SelectedItem.ToString();
            }

            if (sewingTeamTextBox.Text == "" || sewingTeamTextBox.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select Sewing Team");
            }
            else
            {

                efficency.SewingTeam = sewingTeamTextBox.Text;
            }

            if (SupervisorNameComboBox.SelectedItem == "" || SupervisorNameComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select Supervisor");
            }
            else
            {

                efficency.Supervisor = SupervisorNameComboBox.SelectedItem.ToString();
            }

            if (attendenceTextBox.Text == "" || attendenceTextBox.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Please enter total number of attendeance");
            }
            else
            {

                efficency.Attendance = Convert.ToDecimal(attendenceTextBox.Text);
            }
            
            if (buyerComboBox.SelectedItem == "" || buyerComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select buyer");
            }
            else
            {

                efficency.BuyerName = buyerComboBox.SelectedItem.ToString();
            }


            if (serialNumberTextBox.Text == "" || serialNumberTextBox.Text == null)
            {
                efficency.SerialNumber = "";
            }
            else
            {

                efficency.SerialNumber = serialNumberTextBox.Text;
            }

            if (styleNumberTextBox.Text == "" || styleNumberTextBox.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Please enter style number");
            }
            else
            {

                efficency.StyleNumber = styleNumberTextBox.Text;
            }

            if (sampleTypeTextBox.Text == "" || sampleTypeTextBox.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Please enter sample type");
            }
            else
            {

                efficency.SampleType = sampleTypeTextBox.Text;
            }


            if (itemCategoryComboBox.SelectedItem == "" || itemCategoryComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select buyer");
            }
            else
            {

                efficency.ItemCategory = itemCategoryComboBox.SelectedItem.ToString();
            }

            if (smvFactorComboBox.SelectedItem == "" || smvFactorComboBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select buyer");
            }
            else
            {

                efficency.SmvFactor = smvFactorComboBox.SelectedItem.ToString();
            }
            


			efficency.SampleMaker = Convert.ToInt32(sampleMakerTextBox.Text);
            efficency.SampleMakingTime = Convert.ToInt32(sampleMakeTimeTextBox.Text);
			efficency.ProductQuentity = Convert.ToInt32(productQuantityTextBox.Text);
			efficency.SmvValue = Convert.ToDecimal(smvTextBox.Text);

            if (overtime105TextBox.Text == "" || overtime105TextBox.Text == null)
            {
                efficency.OverTime105Person = 0;
            }
            else
            {

                efficency.OverTime105Person = Convert.ToInt16(overtime105TextBox.Text);
            }

            if (overTime120TextBox.Text == "" || overTime120TextBox.Text == null)
            {
                efficency.OverTime120Person = 0;
            }
            else
            {

                efficency.OverTime120Person = Convert.ToInt16(overTime120TextBox.Text);
            }

            if (overTime90TextBox.Text == "" || overTime90TextBox.Text == null)
            {
                efficency.OverTime90Person = 0;
            }
            else
            {

                efficency.OverTime90Person = Convert.ToInt16(overTime90TextBox.Text);
            }
            


			if (machineLoseTextBox.Text == null || machineLoseTextBox.Text == "")
			{
				efficency.MachineLostTime = 0;
			}
			else
			{
				efficency.MachineLostTime = Convert.ToInt32(machineLoseTextBox.Text);
			}

			if (merchantLostTextBox.Text == null || merchantLostTextBox.Text == "")
			{
				efficency.MerchantLostTime = 0;
			}
			else
			{
				efficency.MerchantLostTime = Convert.ToInt32(merchantLostTextBox.Text);
			}

			if (patternLostTextBox.Text == null || patternLostTextBox.Text == "")
			{
				efficency.PatternLostTime = 0;
			}
			else
			{
				efficency.PatternLostTime = Convert.ToInt32(patternLostTextBox.Text);
			}

			if (EmbiLostTextBox.Text == null || EmbiLostTextBox.Text == "")
			{
				efficency.EmbiLostTime = 0;
			}
			else
			{
				efficency.EmbiLostTime = Convert.ToInt32(EmbiLostTextBox.Text);
			}

			if (otherLostTextBox.Text == null || otherLostTextBox.Text == "")
			{
				efficency.OtherLostTime = 0;
			}
			else
			{
				efficency.OtherLostTime = Convert.ToInt32(otherLostTextBox.Text);
			}

			efficency.TotalLostTime = efficency.MachineLostTime + efficency.MerchantLostTime + efficency.PatternLostTime + efficency.EmbiLostTime + efficency.OtherLostTime;



			if (overTime90TextBox.Text == "" || overTime90TextBox.Text == null)
			{
				efficency.OverTime90Person = 0;
			}
			else {
				efficency.OverTime90Person = Convert.ToInt32(overTime90TextBox.Text);
			}

            if (overtime105TextBox.Text == "" || overtime105TextBox.Text == null)
            {
                efficency.OverTime105Person = 0;
            }
            else
            {
                efficency.OverTime105Person = Convert.ToInt32(overtime105TextBox.Text);
            }

            if (overTime120TextBox.Text == "" || overTime120TextBox.Text == null)

            {
                efficency.OverTime120Person = 0;
            }
            else
            {
                efficency.OverTime120Person = Convert.ToInt32(overTime120TextBox.Text);
            }


            if (departmentComboBox.SelectedItem == "" || departmentComboBox.SelectedItem == null)
            {
                efficency.Department = "";
            }
            else {
                efficency.Department = departmentComboBox.SelectedItem.ToString();
            }

            

            efficency.OverTime90 = 90 * efficency.OverTime90Person;
            efficency.OverTime105 = 105 * efficency.OverTime105Person;
            efficency.OverTime120 = 120 * efficency.OverTime120Person;
            efficency.TotalOverTime = efficency.OverTime90 + efficency.OverTime105  + efficency.OverTime120;

            efficency.TotalOfficialTime = efficency.Attendance * Convert.ToDecimal(480);

            efficency.TotalTime = efficency.TotalOfficialTime + efficency.TotalOverTime;

            //A = 5,B = 7,C = 8,D = 9,E = 10,F = 11,G = 12

            switch (efficency.SmvFactor)
            {
                case "A":
                    efficency.SmvFactorValue = 5;
                    break;
                case "B":
                    efficency.SmvFactorValue = 7;
                    break;
                case "C":
                    efficency.SmvFactorValue = 8;
                    break;
                case "D":
                    efficency.SmvFactorValue = 9;
                    break;
                case "E":
                    efficency.SmvFactorValue = 10;
                    break;
                case "F":
                    efficency.SmvFactorValue = 11;
                    break;
                case "G":
                    efficency.SmvFactorValue = 12;
                    break;
                default:
                    efficency.SmvFactorValue = 0;
                    break;
            }

            efficency.Rating = (Convert.ToDecimal(efficency.SmvFactorValue)/Convert.ToDecimal(efficency.SampleMaker));
            efficency.EstimatedTime = ((efficency.SmvValue*efficency.Rating)+((efficency.ProductQuentity-1)*((efficency.SmvValue * efficency.Rating)/2)));

            efficency.TotalProduceMinute = efficency.EstimatedTime * efficency.SampleMaker;


            if (efficency.ProductQuentity <= 20)
            {

                efficency.Fact1Below21 = efficency.TotalProduceMinute;
                    
            }
            else{

                efficency.Fact1Below21 = 0;
            }


            if (efficency.ProductQuentity >= 21)
            {
                efficency.Fact2Above20 = efficency.TotalProduceMinute;
            }
            else
            {
                efficency.Fact2Above20 = 0;
            }

            efficency.TotalFact = efficency.Fact1Below21 + efficency.Fact2Above20;

            efficency.ActualTakenTime = efficency.SampleMaker*efficency.SampleMakingTime;
           
           

            if (efficency.ActualTakenTime == 0)
            {
                efficency.PerformancePercentage = 0;

            }
            else {

                efficency.PerformancePercentage = (efficency.TotalProduceMinute /efficency.ActualTakenTime)*100;
            }
            efficency.MinimumProduceTime = efficency.TotalTime * Convert.ToDecimal(0.45);
            efficency.NonProductiveTime = efficency.TotalTime - efficency.ActualTakenTime;

            efficency.ProductionDate = Convert.ToString(Convert.ToDateTime(productionDateTimePicker.Text).ToShortDateString());
            efficency.Comments = commentTextBox.Text;



            if (efficency.EfficencyId==0)
            {
                dt = efficencyBLL.InsertEfficencyData(efficency);
                if (dt.Rows.Count > 0)
                {
                    returnValue = Convert.ToInt32(dt.Rows[0]["ReturnValue"]);

                    if (returnValue > 0)
                    {

                        massageLabel.Text = "Provided Information Already Exists!!!";
                    }
                    else {
                        System.Windows.Forms.MessageBox.Show("Information Successfully Saved");
                        //massageLabel.Text = "Information Successfully Saved";
                        LoadEfficencyInformation();
                        ClearEfficencyInfo();
                    }

                }
            }
            else
            {
                int actionResult = 0;
                actionResult = efficencyBLL.UpdateEfficencyInfo(efficency);
                if (actionResult > 0)
                {
                    massageLabel.Text = "Information Successfully Updated";
                    LoadEfficencyInformation();
                    ClearEfficencyInfo();

                }
                else {

                    massageLabel.Text = "Provided Information Already Exists!!!";
                }


            }



        }


        public void LoadEfficencyInformation()
        {
            DataTable dt = new DataTable();
            BindingSource dataBind = new BindingSource();
            EfficencyBLL efficencyBLL = new EfficencyBLL();
            dt = efficencyBLL.LoadEfficencyInformation();

            dataBind.DataSource = dt;
            efficencyDataGridView.DataSource = dataBind;

        }

        private void efficencyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            RowId = e.RowIndex;
            DataGridViewRow row = efficencyDataGridView.Rows[RowId];
            Id=Convert.ToInt32(row.Cells[0].Value);
            plantComboBox.SelectedItem= row.Cells[1].Value.ToString();
            sewingTeamTextBox.Text = row.Cells[3].Value.ToString();
            SupervisorNameComboBox.SelectedItem= row.Cells[4].Value.ToString();
            attendenceTextBox.Text = row.Cells[5].Value.ToString();
            buyerComboBox.SelectedItem = row.Cells[9].Value.ToString();
            serialNumberTextBox.Text = row.Cells[11].Value.ToString();
            styleNumberTextBox.Text = row.Cells[12].Value.ToString();
            sampleTypeTextBox.Text = row.Cells[13].Value.ToString();
            itemCategoryComboBox.SelectedItem = row.Cells[14].Value.ToString();
            smvFactorComboBox.SelectedItem = row.Cells[15].Value.ToString();
            sampleMakerTextBox.Text = row.Cells[16].Value.ToString();
            sampleMakeTimeTextBox.Text = row.Cells[19].Value.ToString();
            productQuantityTextBox.Text = row.Cells[17].Value.ToString();
            smvTextBox.Text = row.Cells[18].Value.ToString();
            machineLoseTextBox.Text = row.Cells[20].Value.ToString();
            merchantLostTextBox.Text = row.Cells[21].Value.ToString();
            patternLostTextBox.Text = row.Cells[22].Value.ToString();
            EmbiLostTextBox.Text = row.Cells[23].Value.ToString();
            otherLostTextBox.Text = row.Cells[24].Value.ToString();

            overTime90TextBox.Text = row.Cells[6].Value.ToString();
            overtime105TextBox.Text = row.Cells[7].Value.ToString();
            overTime120TextBox.Text = row.Cells[8].Value.ToString();
            departmentComboBox.SelectedItem = row.Cells[10].Value.ToString();
            productionDateTimePicker.Text= row.Cells[2].Value.ToString();
            commentTextBox.Text= row.Cells[31].Value.ToString();

            if (Id > 0)
            {
                saveButton.Text = "UPDATE";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int actionResult = 0;
            EfficencyBLL effi = new EfficencyBLL();
            try
            {
                if (Id > 0)
                {
                    actionResult = effi.DeleteEfficencyInfo(Id);
                    if(actionResult>0)
                    {
                        massageLabel.Text = "successfully information deleted !!!";
                        LoadEfficencyInformation();
                    }
                    else
                    {

                        massageLabel.Text = "Delete Operation Failed !!!";
                    }
                }
                else
                {
                    massageLabel.Text = "Please do not force to delete information !!!";
                    LoadEfficencyInformation();

                }
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ClearEfficencyInfo()
        {
            Id = 0;
            RowId = 0;
            plantComboBox.Text = "";
            sewingTeamTextBox.Text = "";
            SupervisorNameComboBox.Text = "";
            attendenceTextBox.Text = "";
            buyerComboBox.Text = "";
            serialNumberTextBox.Text = "";
            styleNumberTextBox.Text = "";
            sampleTypeTextBox.Text = "";
            itemCategoryComboBox.Text = "";
            smvFactorComboBox.Text = "";
            sampleMakerTextBox.Text = "";
            sampleMakeTimeTextBox.Text = "";
            productQuantityTextBox.Text = "";
            smvTextBox.Text = "";
            machineLoseTextBox.Text = "";
            merchantLostTextBox.Text = "";
            patternLostTextBox.Text = "";
            EmbiLostTextBox.Text = "";
            otherLostTextBox.Text = "";

            overTime90TextBox.Text = "";
            overtime105TextBox.Text = "";
            overTime120TextBox.Text = "";
            departmentComboBox.Text = "";
            productionDateTimePicker.Text = "";
            saveButton.Text = "Save";
            massageLabel.Text = "";
            commentTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearEfficencyInfo();
        }
    }
}
