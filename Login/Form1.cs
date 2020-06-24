using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection("Data Source=KENU2IEG-ZARIN;Initial Catalog=login1;Integrated Security=True");
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from user1 where username = '" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //int count = 0;
            //while (dr.Read())
            //{
            //    count += 1;
            //}
            //if (count== 1)
            //{
                MessageBox.Show("Ok");
                Master_Entry me = new Master_Entry();
                me.Show();
            //}
            //else if(count >0)
            //{
            //    MessageBox.Show("Duplicate Username and Password");
            //}
            //else
            //{
            //    MessageBox.Show("Username and Password not correct");
            //}
            //textBox1.Clear();
            //textBox2.Clear();

        }
    }
}
