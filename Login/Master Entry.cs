using Login.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Master_Entry : Form
    {
        public Master_Entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser openform = new NewUser();
            openform.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Input openform = new Input();
            openform.Show();
        }

        private void reportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (reportsComboBox.SelectedItem == "Costing Summery")
            {
                CostingSummery openform = new CostingSummery();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Incentive")
            {
                IncentiveSummery openform = new IncentiveSummery();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Email")
            {
                Mail openform = new Mail();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Buyerwise")
            {
                Buyerwise openform = new Buyerwise();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Itemwise")
            {
                Itemwise openform = new Itemwise();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Departmentwise")
            {
                Departmentwise openform = new Departmentwise();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Weekly Lost Time Report")
            {
                WeeklyLostTime openform = new WeeklyLostTime();
                openform.Show();
            }
            if (reportsComboBox.SelectedItem == "Supervisor Lost Time")
            {
                SupervisorLostTime openform = new SupervisorLostTime();
                openform.Show();
            }

        }
       

    }
}
