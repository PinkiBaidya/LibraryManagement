namespace LibraryManagement
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint++;

            if (startpoint <= 100)
            {
                guna2ProgressBar1.Value = startpoint;
                Percentage.Text = startpoint + "%";
            }

            if (startpoint == 101)
            {
                timer1.Stop();

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
