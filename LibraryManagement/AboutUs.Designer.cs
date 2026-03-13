namespace LibraryManagement
{
    partial class AboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 94);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(301, 21);
            label2.Name = "label2";
            label2.Size = new Size(201, 55);
            label2.TabIndex = 6;
            label2.Text = "AboutUs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-1, 142);
            label1.Name = "label1";
            label1.Size = new Size(801, 55);
            label1.TabIndex = 7;
            label1.Text = "This webpage is created by Pinkidev";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(734, 28);
            label3.TabIndex = 8;
            label3.Text = "This webpage is created with C# and vb.net and sql database";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 11);
            panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(749, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutUs";
            Load += AboutUs_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}