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
using System.IO;

namespace Cinnabon
{
    public partial class Registeration : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-11P4SHG; Initial Catalog=Market_DB; Integrated Security=true");

        public Registeration()
        {
            InitializeComponent();
        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }

        private void manager_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void manager_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void manager_first_name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void manager_register_Click(object sender, EventArgs e)
        {


            String c = "";
            if (reg_radio_manager.Checked == true)
            {
                c = "Manager";
            }
            else
            {
                c = "Worker";
            }
            try
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO Employees(FIRST_NAME,SECOND_NAME, EMAIL, PHONE, DEPARTMENT, SALARY, HOURS, USER_NAME, PASSWORD, POSITION,PHOTO, DATE)" +
                        "VALUES('" + reg_1_name.Text + "','" + reg_2_name.Text + "','" + reg_email.Text + "','" + reg_phone.Text + "','" + reg_dept.Text + "','" + reg_salary.Text + "','" + reg_hrs.Text + "','" + reg_UserName.Text + "','" + reg_pass.Text + "','" + c + "', '" + textBox1.Text + "','" + reg_date.Value + "')", cn);
                    cn.Open();
                    sqlCmd.ExecuteNonQuery();
                   MessageBox.Show("Registeration completed successfully :) ","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1 r = new Form1();
                this.Hide();
                r.Show();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                cn.Close();
            }

         


        }
        void Clear()
        {
            reg_1_name.Text = 
                reg_2_name.Text = 
                reg_email.Text = 
                reg_phone.Text = 
                reg_dept.Text = 
                reg_salary.Text =
                reg_UserName.Text=
               reg_pass.Text=
                reg_grop_pos.Text = 
                reg_date.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLoction="";
            try
            {
                OpenFileDialog opendlg = new OpenFileDialog();
                opendlg.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (opendlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                {
                    imageLoction = opendlg.FileName;
                    textBox1.Text = opendlg.FileName.ToString();
                    reg_photo.ImageLocation = imageLoction;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error ocurred", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void reg_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            this.Hide();
            r.ShowDialog();
        }

        private void reg_photo_Click(object sender, EventArgs e)
        {

        }

        private void reg_radio_manager_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
