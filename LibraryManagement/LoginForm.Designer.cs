namespace LibraryManagement
{
    partial class LoginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            UnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(UnameTb);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 486);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(109, 351);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 3;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 30;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Crimson;
            guna2Button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.DodgerBlue;
            guna2Button1.Location = new Point(48, 281);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(204, 58);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "LOGIN";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.CustomizableEdges = customizableEdges3;
            PasswordTb.DefaultText = "Type your User Password";
            PasswordTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PasswordTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTb.Location = new Point(33, 194);
            PasswordTb.Margin = new Padding(4);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PlaceholderText = "";
            PasswordTb.SelectedText = "";
            PasswordTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTb.Size = new Size(251, 54);
            PasswordTb.TabIndex = 2;
            // 
            // UnameTb
            // 
            UnameTb.CustomizableEdges = customizableEdges5;
            UnameTb.DefaultText = "Type your User Name";
            UnameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UnameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UnameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UnameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UnameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UnameTb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            UnameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UnameTb.Location = new Point(33, 119);
            UnameTb.Margin = new Padding(4);
            UnameTb.Name = "UnameTb";
            UnameTb.PlaceholderText = "";
            UnameTb.SelectedText = "";
            UnameTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            UnameTb.Size = new Size(251, 54);
            UnameTb.TabIndex = 1;
            UnameTb.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(66, 40);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 1;
            label1.Text = "USER LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(457, 119);
            label3.Name = "label3";
            label3.Size = new Size(405, 37);
            label3.TabIndex = 4;
            label3.Text = "MECHANICAL DEPARTMENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(512, 169);
            label4.Name = "label4";
            label4.Size = new Size(264, 37);
            label4.TabIndex = 5;
            label4.Text = "CENTRAL LIBRARY";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 486);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox UnameTb;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}