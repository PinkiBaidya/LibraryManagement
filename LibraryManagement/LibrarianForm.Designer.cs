namespace LibraryManagement
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            LibDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Libphone = new Guna.UI2.WinForms.Guna2TextBox();
            label7 = new Label();
            Libpass = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            LibName = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label3 = new Label();
            LibId = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LibDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 130);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1250, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(510, 65);
            label2.Name = "label2";
            label2.Size = new Size(262, 55);
            label2.TabIndex = 5;
            label2.Text = "LIBRARIANS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(277, 10);
            label1.Name = "label1";
            label1.Size = new Size(686, 55);
            label1.TabIndex = 4;
            label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // LibDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            LibDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            LibDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            LibDGV.ColumnHeadersHeight = 30;
            LibDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            LibDGV.DefaultCellStyle = dataGridViewCellStyle3;
            LibDGV.GridColor = Color.FromArgb(231, 229, 255);
            LibDGV.Location = new Point(576, 180);
            LibDGV.Name = "LibDGV";
            LibDGV.RowHeadersVisible = false;
            LibDGV.RowHeadersWidth = 62;
            LibDGV.RowTemplate.Height = 30;
            LibDGV.Size = new Size(684, 586);
            LibDGV.TabIndex = 34;
            LibDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            LibDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            LibDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            LibDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            LibDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            LibDGV.ThemeStyle.BackColor = Color.White;
            LibDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            LibDGV.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            LibDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            LibDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            LibDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            LibDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            LibDGV.ThemeStyle.HeaderStyle.Height = 30;
            LibDGV.ThemeStyle.ReadOnly = false;
            LibDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            LibDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            LibDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LibDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            LibDGV.ThemeStyle.RowsStyle.Height = 30;
            LibDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            LibDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            LibDGV.CellContentClick += LibDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.ForeColor = Color.White;
            button4.Location = new Point(213, 611);
            button4.Name = "button4";
            button4.Size = new Size(147, 50);
            button4.TabIndex = 33;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.White;
            button3.Location = new Point(399, 539);
            button3.Name = "button3";
            button3.Size = new Size(137, 50);
            button3.TabIndex = 32;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.White;
            button2.Location = new Point(213, 539);
            button2.Name = "button2";
            button2.Size = new Size(147, 50);
            button2.TabIndex = 31;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 539);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 30;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Libphone
            // 
            Libphone.CustomizableEdges = customizableEdges1;
            Libphone.DefaultText = "";
            Libphone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Libphone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Libphone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Libphone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Libphone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Libphone.Font = new Font("Segoe UI", 9F);
            Libphone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Libphone.Location = new Point(213, 356);
            Libphone.Margin = new Padding(4, 5, 4, 5);
            Libphone.Name = "Libphone";
            Libphone.PlaceholderText = "";
            Libphone.SelectedText = "";
            Libphone.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Libphone.Size = new Size(237, 46);
            Libphone.TabIndex = 29;
            Libphone.TextChanged += guna2TextBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 356);
            label7.Name = "label7";
            label7.Size = new Size(102, 34);
            label7.TabIndex = 28;
            label7.Text = "Phone";
            // 
            // Libpass
            // 
            Libpass.CustomizableEdges = customizableEdges3;
            Libpass.DefaultText = "";
            Libpass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Libpass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Libpass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Libpass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Libpass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Libpass.Font = new Font("Segoe UI", 9F);
            Libpass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Libpass.Location = new Point(213, 296);
            Libpass.Margin = new Padding(4, 5, 4, 5);
            Libpass.Name = "Libpass";
            Libpass.PlaceholderText = "";
            Libpass.SelectedText = "";
            Libpass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Libpass.Size = new Size(237, 46);
            Libpass.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 296);
            label5.Name = "label5";
            label5.Size = new Size(170, 34);
            label5.TabIndex = 24;
            label5.Text = "PASSWORD";
            // 
            // LibName
            // 
            LibName.CustomizableEdges = customizableEdges5;
            LibName.DefaultText = "";
            LibName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LibName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LibName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LibName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LibName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LibName.Font = new Font("Segoe UI", 9F);
            LibName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LibName.Location = new Point(213, 236);
            LibName.Margin = new Padding(4, 5, 4, 5);
            LibName.Name = "LibName";
            LibName.PlaceholderText = "";
            LibName.SelectedText = "";
            LibName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LibName.Size = new Size(237, 46);
            LibName.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(97, 34);
            label4.TabIndex = 22;
            label4.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 180);
            label3.Name = "label3";
            label3.Size = new Size(42, 34);
            label3.TabIndex = 21;
            label3.Text = "ID";
            // 
            // LibId
            // 
            LibId.CustomizableEdges = customizableEdges7;
            LibId.DefaultText = "";
            LibId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LibId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LibId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LibId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LibId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LibId.Font = new Font("Segoe UI", 9F);
            LibId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LibId.Location = new Point(213, 180);
            LibId.Margin = new Padding(4, 5, 4, 5);
            LibId.Name = "LibId";
            LibId.PlaceholderText = "";
            LibId.SelectedText = "";
            LibId.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LibId.Size = new Size(237, 46);
            LibId.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 815);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 13);
            panel2.TabIndex = 35;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1301, 828);
            Controls.Add(panel2);
            Controls.Add(LibDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Libphone);
            Controls.Add(label7);
            Controls.Add(Libpass);
            Controls.Add(label5);
            Controls.Add(LibName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LibId);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LibrarianForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LibDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView LibDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox Libphone;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Libpass;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox LibName;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox LibId;
        private Panel panel2;
    }
}