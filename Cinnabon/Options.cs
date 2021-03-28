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
    public partial class Options : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-11P4SHG; Initial Catalog=Market_DB; Integrated Security=true");
        public Options(string value)
        {
            InitializeComponent();
            // label1.Text = value;
            this.Value = value;
        }
        public string Value { get; set; }
        public Options()
        {

           
            InitializeComponent();

            //SqlCommand cmd = new SqlCommand("select USER_NAME from Employees where USER_NAME = '" + Form1.uValue + "'", cn);
            //cn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    label1.Text = dr["User_Name"].ToString();
            //}
            //dr.Close();
            //cn.Close();

        }
        
        private void Options_Load(object sender, EventArgs e)
        {
            label1.Text = Value;
        }

        private void get_prod_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 r = new Form2();
            r.ShowDialog();
        }

        private void make_bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill r = new Bill();
            r.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            this.Hide();
            r.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
