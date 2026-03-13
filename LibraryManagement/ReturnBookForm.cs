using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryManagement
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win10\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IssueBookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void populateReturn()
        {
            Con.Open();
            string query = "select * from ReturnTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReturnedBookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillStudent()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT StdId FROM StudentTbl", Con);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(rdr);

            StdCb.DisplayMember = "StdId";
            StdCb.ValueMember = "StdId";
            StdCb.DataSource = dt;

            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BookName FROM BookTbl where Qty>" + 0 + "", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            Bookcb.ValueMember = "BookName";
            Bookcb.DataSource = dt;
            Con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void IssueBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ReturnNumTb.Text = IssueBookDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdCb.SelectedValue = IssueBookDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdNameTb.Text = IssueBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            StddpmntTb.Text = IssueBookDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = IssueBookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bookcb.Text = IssueBookDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void UpdateBookRecord()
        {
            int Qty, newQty;
            Con.Open();
            string query = "SELECT * FROM BookTbl WHERE BookName=@id";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@id", Bookcb.SelectedValue);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty=" + newQty + " where BookName='" + Bookcb.SelectedValue.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            populate();
            populateReturn();
            FillStudent();
            FillBook();

            pictureBox1.Cursor = Cursors.Hand;

            IssueBookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            IssueBookDGV.EnableHeadersVisualStyles = false;
            IssueBookDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            IssueBookDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            IssueBookDGV.ColumnHeadersDefaultCellStyle.Font =
         new Font("Century Gothic", 12, FontStyle.Bold);

            IssueBookDGV.DefaultCellStyle.Font =
                new Font("Century Gothic", 12);


            ReturnedBookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ReturnedBookDGV.EnableHeadersVisualStyles = false;
            ReturnedBookDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            ReturnedBookDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ReturnedBookDGV.ColumnHeadersDefaultCellStyle.Font =
         new Font("Century Gothic", 12, FontStyle.Bold);

            ReturnedBookDGV.DefaultCellStyle.Font =
                new Font("Century Gothic", 12);
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReturnNumTb.Text == "" || StdNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string issueDate = IssueDate.Value.ToString("yyyy-MM-dd");
                    string returnDate = ReturnDate.Value.ToString("yyyy-MM-dd");

                    Con.Open();

                    string query = "INSERT INTO ReturnTbl (ReturnNum, StdId, StdName, StdDept, Stdphone, Bookreturned, IssueDate, ReturnDate) " +
                         "VALUES(" +
                                   ReturnNumTb.Text + "," +
                                   StdCb.SelectedValue + ",'" +
                                   StdNameTb.Text + "','" +
                                   StddpmntTb.Text + "','" +
                                   PhoneTb.Text + "','" +
                                   Bookcb.SelectedValue + "','" +
                                   issueDate + "','" +
                                   returnDate + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Returned Successfully");

                    Con.Close();
                    UpdateBookRecord();
                    populate();
                    populateReturn();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
