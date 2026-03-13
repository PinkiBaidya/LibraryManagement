namespace LibraryManagement
{
    partial class SplashForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            Percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(657, 58);
            label1.TabIndex = 0;
            label1.Text = "LibraryManagementSystem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(541, 67);
            label2.Name = "label2";
            label2.Size = new Size(162, 34);
            label2.TabIndex = 1;
            label2.Text = "Version 1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(211, 402);
            label3.Name = "label3";
            label3.Size = new Size(327, 39);
            label3.TabIndex = 2;
            label3.Text = "PoweredByPinkiDev";
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2ProgressBar1.Location = new Point(-3, 444);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(804, 10);
            guna2ProgressBar1.TabIndex = 3;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ProgressBar1.ValueChanged += guna2ProgressBar1_ValueChanged;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Century Gothic", 27F);
            Percentage.ForeColor = Color.White;
            Percentage.Location = new Point(366, 188);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(70, 65);
            Percentage.TabIndex = 4;
            Percentage.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Percentage);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Label Percentage;
        private System.Windows.Forms.Timer timer1;
    }
}
