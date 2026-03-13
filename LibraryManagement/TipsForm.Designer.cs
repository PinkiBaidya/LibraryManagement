namespace LibraryManagement
{
    partial class TipsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipsForm));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(343, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 55);
            label2.TabIndex = 6;
            label2.Text = "Tips";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 11);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Crimson;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(343, 193);
            label1.Name = "label1";
            label1.Size = new Size(98, 55);
            label1.TabIndex = 8;
            label1.Text = "Tips";
            // 
            // TipsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TipsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel3;
        private Label label1;
    }
}