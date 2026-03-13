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
    public partial class BookTbl : Form
    {
        public BookTbl()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win10\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label5_Click(object sender, EventArgs e)
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
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BookTbl_Load(object sender, EventArgs e)
        {
            populate();



            pictureBox1.Cursor = Cursors.Hand;


            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            BookDGV.EnableHeadersVisualStyles = false;
            BookDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            BookDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BookDGV.ColumnHeadersDefaultCellStyle.Font =
         new Font("Century Gothic", 12, FontStyle.Bold);

            BookDGV.DefaultCellStyle.Font =
                new Font("Century Gothic", 12);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "" || author.Text == "" || publisher.Text == "" || price.Text == "" || quantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "INSERT INTO BookTbl (BookName, Author, Publisher, Price, Qty) VALUES (@BName, @Author, @Publisher, @Price, @Qty)";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@BName", bookname.Text);
                    cmd.Parameters.AddWithValue("@Author", author.Text);
                    cmd.Parameters.AddWithValue("@Publisher", publisher.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(price.Text));
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(quantity.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookname.Text = BookDGV.SelectedRows[0].Cells[0].Value.ToString();
            author.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            publisher.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            quantity.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
        //private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "")
            {
                MessageBox.Show("Enter the Book Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTbl where BookName='" + bookname.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "" || author.Text == "" || publisher.Text == "" || price.Text == "" || quantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTbl set Author='" + author.Text +
                          "',Publisher='" + publisher.Text +
                          "',Price=" + price.Text +
                          ",Qty=" + quantity.Text +
                          " where BookName='" + bookname.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated successfully");
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
