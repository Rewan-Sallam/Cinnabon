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
    public partial class manager : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-11P4SHG; Initial Catalog=Market_DB; Integrated Security=true");

        public manager()
        {
            InitializeComponent();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                name.Text = row.Cells["FIRST_NAME"].Value.ToString();
                company.Text = row.Cells["SECOND_NAME"].Value.ToString();
                price.Text = row.Cells["EMAIL"].Value.ToString();
                number.Text = row.Cells["PHONE"].Value.ToString();
                textBox7.Text = row.Cells["DEPARTMENT"].Value.ToString();
                textBox8.Text = row.Cells["SALARY"].Value.ToString();
                textBox1.Text = row.Cells["HOURS"].Value.ToString();
                textBox2.Text = row.Cells["USER_NAME"].Value.ToString();
                textBox3.Text = row.Cells["PASSWORD"].Value.ToString();
                textBox4.Text = row.Cells["POSITION"].Value.ToString();
                textBox6.Text = row.Cells["DATE"].Value.ToString();


            }
        }

       
        public void disp_data()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select FIRST_NAME,SECOND_NAME,EMAIL,PHONE,DEPARTMENT,SALARY,HOURS,USER_NAME,PASSWORD,POSITION,DATE from Employees";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProducts.DataSource = dt;

            cn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employees  set FIRST_NAME='" + name.Text + "',SECOND_NAME='" + company.Text + "',EMAIL='" + price.Text + "',PHONE='" + number.Text + "',DEPARTMENT='" + textBox7.Text + "',SALARY='" + textBox8.Text + "',HOURS='" + textBox1.Text + "',USER_NAME='" + textBox2.Text + "',PASSWORD='" + textBox3.Text + "',POSITION='" + textBox4.Text +"',DATE='" + textBox6.Text + "'  where FIRST_NAME='" + name.Text + "'";
            cmd.ExecuteNonQuery();
            cn.Close();
            disp_data();
            MessageBox.Show("Employee data is updated successfully !");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employees where FIRST_NAME='" + name.Text + "'";
            cmd.ExecuteNonQuery();
            cn.Close();
            disp_data();
            MessageBox.Show("Employee data is deleted successfully !");

        }

        private void search_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees where FIRST_NAME='" + name.Text + "'";
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

        private void manager_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            this.Hide();
            r.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                name.Text = row.Cells["FIRST_NAME"].Value.ToString();
                company.Text = row.Cells["SECOND_NAME"].Value.ToString();
                price.Text = row.Cells["EMAIL"].Value.ToString();
                number.Text = row.Cells["PHONE"].Value.ToString();
                textBox7.Text = row.Cells["DEPARTMENT"].Value.ToString();
                textBox8.Text = row.Cells["SALARY"].Value.ToString();
                textBox1.Text = row.Cells["HOURS"].Value.ToString();
                textBox2.Text = row.Cells["USER_NAME"].Value.ToString();
                textBox3.Text = row.Cells["PASSWORD"].Value.ToString();
                textBox4.Text = row.Cells["POSITION"].Value.ToString();
                textBox6.Text = row.Cells["DATE"].Value.ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
