namespace LibraryManagement
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            StdId = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label4 = new Label();
            StdName = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            StdDep = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            Stdsem = new ComboBox();
            label7 = new Label();
            Stdphone = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            StudentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).BeginInit();
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
            panel1.Size = new Size(1299, 126);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1248, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(510, 65);
            label2.Name = "label2";
            label2.Size = new Size(201, 55);
            label2.TabIndex = 5;
            label2.Text = "STUDENT";
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
            // StdId
            // 
            StdId.CustomizableEdges = customizableEdges1;
            StdId.DefaultText = "";
            StdId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            StdId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            StdId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            StdId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            StdId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            StdId.Font = new Font("Segoe UI", 9F);
            StdId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            StdId.Location = new Point(209, 207);
            StdId.Margin = new Padding(4, 5, 4, 5);
            StdId.Name = "StdId";
            StdId.PlaceholderText = "";
            StdId.SelectedText = "";
            StdId.ShadowDecoration.CustomizableEdges = customizableEdges2;
            StdId.Size = new Size(237, 46);
            StdId.TabIndex = 1;
            StdId.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 207);
            label3.Name = "label3";
            label3.Size = new Size(60, 34);
            label3.TabIndex = 6;
            label3.Text = "Usn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 265);
            label4.Name = "label4";
            label4.Size = new Size(99, 34);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // StdName
            // 
            StdName.CustomizableEdges = customizableEdges3;
            StdName.DefaultText = "";
            StdName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            StdName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            StdName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            StdName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            StdName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            StdName.Font = new Font("Segoe UI", 9F);
            StdName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            StdName.Location = new Point(209, 263);
            StdName.Margin = new Padding(4, 5, 4, 5);
            StdName.Name = "StdName";
            StdName.PlaceholderText = "";
            StdName.SelectedText = "";
            StdName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            StdName.Size = new Size(237, 46);
            StdName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 336);
            label5.Name = "label5";
            label5.Size = new Size(181, 34);
            label5.TabIndex = 9;
            label5.Text = "Department";
            // 
            // StdDep
            // 
            StdDep.CustomizableEdges = customizableEdges5;
            StdDep.DefaultText = "";
            StdDep.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            StdDep.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            StdDep.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            StdDep.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            StdDep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            StdDep.Font = new Font("Segoe UI", 9F);
            StdDep.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            StdDep.Location = new Point(209, 336);
            StdDep.Margin = new Padding(4, 5, 4, 5);
            StdDep.Name = "StdDep";
            StdDep.PlaceholderText = "";
            StdDep.SelectedText = "";
            StdDep.ShadowDecoration.CustomizableEdges = customizableEdges6;
            StdDep.Size = new Size(237, 46);
            StdDep.TabIndex = 10;
            StdDep.TextChanged += guna2TextBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 404);
            label6.Name = "label6";
            label6.Size = new Size(138, 34);
            label6.TabIndex = 11;
            label6.Text = "Semester";
            // 
            // Stdsem
            // 
            Stdsem.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Stdsem.FormattingEnabled = true;
            Stdsem.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            Stdsem.Location = new Point(209, 404);
            Stdsem.Name = "Stdsem";
            Stdsem.Size = new Size(237, 42);
            Stdsem.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(21, 463);
            label7.Name = "label7";
            label7.Size = new Size(102, 34);
            label7.TabIndex = 13;
            label7.Text = "Phone";
            // 
            // Stdphone
            // 
            Stdphone.CustomizableEdges = customizableEdges7;
            Stdphone.DefaultText = "";
            Stdphone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Stdphone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Stdphone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Stdphone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Stdphone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Stdphone.Font = new Font("Segoe UI", 9F);
            Stdphone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Stdphone.Location = new Point(209, 463);
            Stdphone.Margin = new Padding(4, 5, 4, 5);
            Stdphone.Name = "Stdphone";
            Stdphone.PlaceholderText = "";
            Stdphone.SelectedText = "";
            Stdphone.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Stdphone.Size = new Size(237, 46);
            Stdphone.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 566);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.White;
            button2.Location = new Point(209, 566);
            button2.Name = "button2";
            button2.Size = new Size(147, 50);
            button2.TabIndex = 16;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.White;
            button3.Location = new Point(395, 566);
            button3.Name = "button3";
            button3.Size = new Size(137, 50);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.ForeColor = Color.White;
            button4.Location = new Point(209, 638);
            button4.Name = "button4";
            button4.Size = new Size(147, 50);
            button4.TabIndex = 18;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // StudentDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            StudentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StudentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StudentDGV.ColumnHeadersHeight = 33;
            StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            StudentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            StudentDGV.GridColor = Color.FromArgb(231, 229, 255);
            StudentDGV.Location = new Point(572, 207);
            StudentDGV.Name = "StudentDGV";
            StudentDGV.RowHeadersVisible = false;
            StudentDGV.RowHeadersWidth = 62;
            StudentDGV.Size = new Size(681, 586);
            StudentDGV.TabIndex = 19;
            StudentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            StudentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            StudentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            StudentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            StudentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            StudentDGV.ThemeStyle.BackColor = Color.White;
            StudentDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            StudentDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            StudentDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            StudentDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            StudentDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            StudentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            StudentDGV.ThemeStyle.HeaderStyle.Height = 33;
            StudentDGV.ThemeStyle.ReadOnly = false;
            StudentDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            StudentDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StudentDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            StudentDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            StudentDGV.ThemeStyle.RowsStyle.Height = 33;
            StudentDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            StudentDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            StudentDGV.CellContentClick += StudentDGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 815);
            panel2.Name = "panel2";
            panel2.Size = new Size(1299, 13);
            panel2.TabIndex = 20;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1299, 828);
            Controls.Add(panel2);
            Controls.Add(StudentDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Stdphone);
            Controls.Add(label7);
            Controls.Add(Stdsem);
            Controls.Add(label6);
            Controls.Add(StdDep);
            Controls.Add(label5);
            Controls.Add(StdName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StdId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox StdId;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox StdName;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox StdDep;
        private Label label6;
        private ComboBox Stdsem;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Stdphone;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Guna.UI2.WinForms.Guna2DataGridView StudentDGV;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}