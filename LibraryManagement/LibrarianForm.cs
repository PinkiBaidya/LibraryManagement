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
using Microsoft.Data.SqlClient;

namespace LibraryManagement
{
    public partial class LibrarianForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win10\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            populate();

            LibDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LibDGV.EnableHeadersVisualStyles = false;
            LibDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            LibDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            LibDGV.ColumnHeadersDefaultCellStyle.Font =
         new Font("Century Gothic", 12, FontStyle.Bold);

            LibDGV.DefaultCellStyle.Font =
                new Font("Century Gothic", 12);
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void populate()
        {
            Con.Open();
            string query = "select * from LibrarianTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LibDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into LibrarianTbl values(" + LibId.Text + ",'" + LibName.Text + "','" + Libpass.Text + "','" + Libphone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Added successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "")
            {
                MessageBox.Show("Enter the Librarian Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from LibrarianTbl where LibId=" + LibId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Deleted successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LibDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LibId.Text = LibDGV.SelectedRows[0].Cells[0].Value.ToString();
            LibName.Text = LibDGV.SelectedRows[0].Cells[1].Value.ToString();
            Libpass.Text = LibDGV.SelectedRows[0].Cells[2].Value.ToString();
            Libphone.Text = LibDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update LibrarianTbl set LibName='" + LibName.Text + "',LibPassword='" + Libpass.Text + "',LibPhone='" + Libphone.Text + "' where LibId=" + LibId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Updated successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
