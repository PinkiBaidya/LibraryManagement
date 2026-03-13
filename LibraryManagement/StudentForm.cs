using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win10\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DodgerBlue;
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            populate();

            pictureBox1.Cursor = Cursors.Hand;


            StudentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            StudentDGV.EnableHeadersVisualStyles = false;
            StudentDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            StudentDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            StudentDGV.ColumnHeadersDefaultCellStyle.Font =
         new Font("Century Gothic", 12, FontStyle.Bold);

            StudentDGV.DefaultCellStyle.Font =
                new Font("Century Gothic", 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || StdDep.Text == "" || Stdsem.SelectedItem.ToString() == "" || Stdphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into StudentTbl values(" + StdId.Text + ",'" + StdName.Text + "','" + StdDep.Text + "','" + Stdsem.SelectedItem.ToString() + "','" + Stdphone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "")
            {
                MessageBox.Show("Enter the Student Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from StudentTbl where StdId=" + StdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdDep.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            Stdsem.SelectedItem = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            Stdphone.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || StdDep.Text == "" || Stdsem.SelectedItem.ToString() == "" || Stdphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update StudentTbl set StdName='" + StdName.Text + "',StdDep='" + StdDep.Text + "', StdSem='"+ Stdsem.SelectedItem.ToString()+"',StdPhone='" + Stdphone.Text + "' where StdId=" + StdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
