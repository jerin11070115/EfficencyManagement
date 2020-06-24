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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

		private void submitButton_Click(object sender, EventArgs e)
		{
			int UserId = 0;
			int value = 0;
			Users users = new Users();

			users.UserName = userNameTextBox.Text;
			users.FullName = fullNameTextBox.Text;
			users.Password = passwordTextBox.Text;
			users.ConfirmPassword = confirmPasswordTextBox.Text;
			users.IsActive = isActiveComboBox.SelectedItem.ToString();
			users.UserType = userTypeComboBox.SelectedItem.ToString();

			if (UserId == 0)
			{
				if (users.Password == users.ConfirmPassword)
				{
					UserBLL userBLL = new UserBLL();
					DataTable dt = userBLL.InsertUserInformation(users);

					if (dt.Rows.Count > 0)
					{
						value = Convert.ToInt32(dt.Rows[0]["valid"]);

						if (value > 0)
						{

							massagelabel.Text = users.UserName + " Already Exists !!!";
						}
						else
						{
							massagelabel.Text = users.UserName + " Successfully Saved !!!";
						}
					}
				}
				else {
					massagelabel.Text = " Password Dose Not Match !!!";

				}
				

			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
