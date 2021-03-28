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

    public partial class Bill : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-11P4SHG; Initial Catalog=Market_DB; Integrated Security=true");
        
        public Bill()
        {
            InitializeComponent();
      



        }
        

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void disp_data()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ITEMS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProducts1.DataSource = dt;

            cn.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
         


            disp_data();

        }
        private void dgvProducts1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["NAME"].Value.ToString();

                Products.Items.Add(row.Cells["NAME"].Value.ToString());
                Prices.Items.Add(row.Cells["PRICE"].Value.ToString());

        

            }
        }
        private void dgvProducts1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvProducts1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts1.Rows[e.RowIndex];
                Products.Items.Add(row.Cells["NAME"].Value.ToString());
                Prices.Items.Add(row.Cells["PRICE"].Value.ToString());

            }

        }

        private void dgvProducts1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts1.Rows[e.RowIndex];
                Products.Items.Add(row.Cells["NAME"].Value.ToString());
                Prices.Items.Add(row.Cells["PRICE"].Value.ToString());

            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ITEMS where NAME='" + hh.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProducts1.DataSource = dt;

            cn.Close();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            double c=0;
            for (int i = 0; i < Prices.Items.Count; i++)
            {
                double a = Convert.ToDouble(Prices.Items[i].ToString());
                double b = 0;
                if (i == 0)
                {

                    b = a * Convert.ToDouble(textBox1.Text);
                }
                else if (i == 1)
                {
                    b = a * Convert.ToDouble(textBox2.Text);
                }
                else if (i == 2)
                {
                    b = a * Convert.ToDouble(textBox3.Text);
                }
                else if (i == 3)
                {
                    b = a * Convert.ToDouble(textBox4.Text);
                }
                else if (i == 4)
                {
                    b = a * Convert.ToDouble(textBox5.Text);
                }
                else if (i == 5)
                {
                    b = a * Convert.ToDouble(textBox6.Text);
                }
                else if (i == 6)
                {
                    b = a * Convert.ToDouble(textBox7.Text);
                }
                else if (i == 7)
                {
                    b = a * Convert.ToDouble(textBox8.Text);
                }
                else if (i == 8)
                {
                    b = a * Convert.ToDouble(textBox9.Text);
                }
                c = c + b;
            }
               
                lt.Text = Convert.ToString(c) + "$";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_to_bill_btn_Click(object sender, EventArgs e)
        {

        }

        private void create_inv_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            if (Products.Items.Count == 10)
            {


                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Products.Items[7].ToString(), Products.Items[8].ToString(), Products.Items[9].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), Prices.Items[7].ToString(), Prices.Items[8].ToString(), Prices.Items[9].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text,lt.Text);
                r.ShowDialog();
                Options b = new Options(lt.Text);
            }
            if (Products.Items.Count == 9)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Products.Items[7].ToString(), Products.Items[8].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), Prices.Items[7].ToString(), Prices.Items[8].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, lt.Text);
                r.ShowDialog();
            }

            if (Products.Items.Count == 8)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Products.Items[7].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), Prices.Items[7].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, lt.Text);
                r.ShowDialog();
            }

            if (Products.Items.Count == 7)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 6)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(),  Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(),  textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 5)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(),  Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 4)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(),  Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(),  textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 3)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(),  textBox1.Text, textBox2.Text, textBox3.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 2)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), textBox1.Text, textBox2.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 1)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(),  Prices.Items[0].ToString(), textBox1.Text, lt.Text);
                r.ShowDialog();
            }

        }
    }
}
