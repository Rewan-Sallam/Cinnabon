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
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-11P4SHG; Initial Catalog=Market_DB; Integrated Security=true");

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                name.Text = row.Cells["NAME"].Value.ToString();
                company.Text = row.Cells["COMPANY"].Value.ToString();
                price.Text = row.Cells["PRICE"].Value.ToString();
                number.Text = row.Cells["PIECES"].Value.ToString();
                pro.Text = row.Cells["PRO_DATE"].Value.ToString();
                exp.Text = row.Cells["EXP_DATE"].Value.ToString();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ITEMS values('"+name.Text+ "','" + company.Text + "','" + price.Text + "','" + number.Text + "','" + pro.Value + "','" + exp.Value + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            name.Text = company.Text = price.Text = number.Text = "";
            disp_data();
            MessageBox.Show("item is inserted successfully !");
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
            dgvProducts.DataSource = dt;
            
            cn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ITEMS where NAME='"+name.Text+"'";
            cmd.ExecuteNonQuery();
            cn.Close();
            disp_data();
            MessageBox.Show("item is deleted successfully !");


        }

        private void update_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ITEMS  set NAME='"+name.Text+ "',COMPANY='" + company.Text + "',PRICE='" + price.Text + "',PIECES='" + number.Text + "',PRO_DATE='" + pro.Value + "',EXP_DATE='" + exp.Value + "' where NAME='" + name.Text + "'";
            cmd.ExecuteNonQuery();
            cn.Close();
            disp_data();
            MessageBox.Show("item is updated successfully !");
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                name.Text = row.Cells["NAME"].Value.ToString();
                company.Text = row.Cells["COMPANY"].Value.ToString();
                price.Text = row.Cells["PRICE"].Value.ToString();
                number.Text = row.Cells["PIECES"].Value.ToString();
                pro.Text = row.Cells["PRO_DATE"].Value.ToString();
                exp.Text = row.Cells["EXP_DATE"].Value.ToString();

            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ITEMS where NAME='" + name.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProducts.DataSource = dt;

            cn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Options r = new Options();
            this.Hide();
            r.ShowDialog();
        }
    }
}
