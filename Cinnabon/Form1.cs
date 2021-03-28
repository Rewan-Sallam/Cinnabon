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

namespace Cinnabon
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-11P4SHG; Initial Catalog=Market_DB; Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }
       
       public static string uValue;
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void new_mem_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registeration r = new Registeration();
            r.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Worker_Login_Click(object sender, EventArgs e)
        {

            string query = "Select * from Employees Where User_Name = '" + work_name.Text.Trim() + "' and PASSWORD = '" + work_pass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,cn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
               
                this.Hide();
                Options r = new Options(work_name.Text);
                Invoice b = new Invoice(work_name.Text);
                r.ShowDialog();
               

            }
            else
            {
                MessageBox.Show(" inValid UserName or Password ! ");
            }





          
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void man_UserNmae_TextChanged(object sender, EventArgs e)
        {

        }

        private void man_login_Click(object sender, EventArgs e)
        {
            string query = "Select * from Employees Where User_Name = '" + man_UserNmae.Text.Trim() + "' and PASSWORD = '" + man_pass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Options r = new Options(man_UserNmae.Text.Trim());
                manager b = new manager();
                r.Value = man_UserNmae.Text;
                b.ShowDialog();
                this.Hide();
               
               
            }
            else
            {
                MessageBox.Show(" inValid UserName or Password ! ");
            }
        }

        private void work_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(work_name.Text.Trim()))
            {
                errorProvider1.SetError(work_name, "Name is required.");
            }
        }

        private void work_pass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(work_name.Text.Trim()))
            {
                errorProvider2.SetError(work_name, "Password is required.");
            }
        }
    }
}
