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
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win10\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT StdId FROM StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(rdr);
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
        private void fetchstddata()
        {
            if (StdCb.SelectedValue == null || StdCb.SelectedValue is DataRowView)
                return;

            Con.Open();

            string query = "SELECT * FROM StudentTbl WHERE StdId=@id";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@id", StdCb.SelectedValue);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StdNameTb.Text = dr["StdName"].ToString();
                StddpmntTb.Text = dr["StdDep"].ToString();
                PhoneTb.Text = dr["StdPhone"].ToString();
            }

            Con.Close();
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
                newQty = Qty - 1;
                string query1 = "update BookTbl set Qty=" + newQty + " where BookName='" + Bookcb.SelectedValue.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }
        private void UpdateBookCancellation()
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
                Qty = Convert.ToInt32(dr["Qty"]);
                newQty = Qty + 1;

                string query1 = "UPDATE BookTbl SET Qty=@qty WHERE BookName=@name";

                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.Parameters.AddWithValue("@qty", newQty);
                cmd1.Parameters.AddWithValue("@name", Bookcb.SelectedValue);

                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            populate();

            pictureBox1.Cursor = Cursors.Hand;


            IssueBookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            IssueBookDGV.EnableHeadersVisualStyles = false;
            IssueBookDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            IssueBookDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            IssueBookDGV.ColumnHeadersDefaultCellStyle.Font =
         new Font("Century Gothic", 12, FontStyle.Bold);

            IssueBookDGV.DefaultCellStyle.Font =
                new Font("Century Gothic", 12);

            IssueDate.Format = DateTimePickerFormat.Custom;
            IssueDate.CustomFormat = "yyyy/MM/dd";

            IssueBookDGV.Columns["IssueDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void StdCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void StdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IssueNumTb.Text == "" || StdNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string issueDate = IssueDate.Value.ToString("yyyy-MM-dd");

                    Con.Open();

                    string query = "INSERT INTO IssueTbl VALUES(" +
                                   IssueNumTb.Text + "," +
                                   StdCb.SelectedValue + ",'" +
                                   StdNameTb.Text + "','" +
                                   StddpmntTb.Text + "','" +
                                   PhoneTb.Text + "','" +
                                   Bookcb.SelectedValue + "','" +
                                   issueDate + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Issued Successfully");

                    Con.Close();
                    UpdateBookRecord();
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
            if (IssueNumTb.Text == "")
            {
                MessageBox.Show("Enter the IssueNumber");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from IssueTbl where IssueNum=" + IssueNumTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Issue Deleted cancelled");
                    Con.Close();
                    UpdateBookCancellation();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void IssueBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueNumTb.Text = IssueBookDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdCb.SelectedItem = IssueBookDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdNameTb.Text = IssueBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            StddpmntTb.Text = IssueBookDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = IssueBookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bookcb.Text = IssueBookDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
