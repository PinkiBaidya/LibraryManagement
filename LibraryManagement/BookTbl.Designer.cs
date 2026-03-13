namespace LibraryManagement
{
    partial class BookTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTbl));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            BookDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            quantity = new Guna.UI2.WinForms.Guna2TextBox();
            label7 = new Label();
            label6 = new Label();
            publisher = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            author = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label3 = new Label();
            bookname = new Guna.UI2.WinForms.Guna2TextBox();
            price = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
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
            panel1.Size = new Size(1308, 126);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1257, 0);
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
            label2.Size = new Size(173, 55);
            label2.TabIndex = 5;
            label2.Text = "BOOKS";
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
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 815);
            panel2.Name = "panel2";
            panel2.Size = new Size(1308, 13);
            panel2.TabIndex = 21;
            // 
            // BookDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.ColumnHeadersHeight = 33;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BookDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BookDGV.GridColor = Color.FromArgb(231, 229, 255);
            BookDGV.Location = new Point(582, 189);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersVisible = false;
            BookDGV.RowHeadersWidth = 62;
            BookDGV.Size = new Size(644, 586);
            BookDGV.TabIndex = 36;
            BookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BookDGV.ThemeStyle.BackColor = Color.White;
            BookDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BookDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BookDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BookDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            BookDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BookDGV.ThemeStyle.HeaderStyle.Height = 33;
            BookDGV.ThemeStyle.ReadOnly = false;
            BookDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BookDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BookDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            BookDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BookDGV.ThemeStyle.RowsStyle.Height = 33;
            BookDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BookDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.ForeColor = Color.White;
            button4.Location = new Point(219, 620);
            button4.Name = "button4";
            button4.Size = new Size(147, 50);
            button4.TabIndex = 35;
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
            button3.Location = new Point(405, 548);
            button3.Name = "button3";
            button3.Size = new Size(137, 50);
            button3.TabIndex = 34;
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
            button2.Location = new Point(219, 548);
            button2.Name = "button2";
            button2.Size = new Size(147, 50);
            button2.TabIndex = 33;
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
            button1.Location = new Point(31, 548);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 32;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // quantity
            // 
            quantity.CustomizableEdges = customizableEdges1;
            quantity.DefaultText = "";
            quantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            quantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            quantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            quantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            quantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            quantity.Font = new Font("Segoe UI", 9F);
            quantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            quantity.Location = new Point(219, 420);
            quantity.Margin = new Padding(4, 5, 4, 5);
            quantity.Name = "quantity";
            quantity.PlaceholderText = "";
            quantity.SelectedText = "";
            quantity.ShadowDecoration.CustomizableEdges = customizableEdges2;
            quantity.Size = new Size(237, 46);
            quantity.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(31, 420);
            label7.Name = "label7";
            label7.Size = new Size(134, 34);
            label7.TabIndex = 30;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(31, 361);
            label6.Name = "label6";
            label6.Size = new Size(83, 34);
            label6.TabIndex = 28;
            label6.Text = "Price";
            // 
            // publisher
            // 
            publisher.CustomizableEdges = customizableEdges3;
            publisher.DefaultText = "";
            publisher.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            publisher.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            publisher.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            publisher.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            publisher.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            publisher.Font = new Font("Segoe UI", 9F);
            publisher.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            publisher.Location = new Point(219, 301);
            publisher.Margin = new Padding(4, 5, 4, 5);
            publisher.Name = "publisher";
            publisher.PlaceholderText = "";
            publisher.SelectedText = "";
            publisher.ShadowDecoration.CustomizableEdges = customizableEdges4;
            publisher.Size = new Size(237, 46);
            publisher.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 301);
            label5.Name = "label5";
            label5.Size = new Size(135, 34);
            label5.TabIndex = 26;
            label5.Text = "Publisher";
            label5.Click += label5_Click;
            // 
            // author
            // 
            author.CustomizableEdges = customizableEdges5;
            author.DefaultText = "";
            author.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            author.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            author.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            author.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            author.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            author.Font = new Font("Segoe UI", 9F);
            author.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            author.Location = new Point(219, 245);
            author.Margin = new Padding(4, 5, 4, 5);
            author.Name = "author";
            author.PlaceholderText = "";
            author.SelectedText = "";
            author.ShadowDecoration.CustomizableEdges = customizableEdges6;
            author.Size = new Size(237, 46);
            author.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(31, 247);
            label4.Name = "label4";
            label4.Size = new Size(106, 34);
            label4.TabIndex = 24;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 189);
            label3.Name = "label3";
            label3.Size = new Size(165, 34);
            label3.TabIndex = 23;
            label3.Text = "BookName";
            // 
            // bookname
            // 
            bookname.CustomizableEdges = customizableEdges7;
            bookname.DefaultText = "";
            bookname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            bookname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            bookname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            bookname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            bookname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            bookname.Font = new Font("Segoe UI", 9F);
            bookname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            bookname.Location = new Point(219, 189);
            bookname.Margin = new Padding(4, 5, 4, 5);
            bookname.Name = "bookname";
            bookname.PlaceholderText = "";
            bookname.SelectedText = "";
            bookname.ShadowDecoration.CustomizableEdges = customizableEdges8;
            bookname.Size = new Size(237, 46);
            bookname.TabIndex = 22;
            // 
            // price
            // 
            price.CustomizableEdges = customizableEdges9;
            price.DefaultText = "";
            price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            price.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            price.Font = new Font("Segoe UI", 9F);
            price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            price.Location = new Point(219, 361);
            price.Margin = new Padding(4, 5, 4, 5);
            price.Name = "price";
            price.PlaceholderText = "";
            price.SelectedText = "";
            price.ShadowDecoration.CustomizableEdges = customizableEdges10;
            price.Size = new Size(237, 46);
            price.TabIndex = 37;
            // 
            // BookTbl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1308, 828);
            Controls.Add(price);
            Controls.Add(BookDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(quantity);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(publisher);
            Controls.Add(label5);
            Controls.Add(author);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bookname);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookTbl";
            Text = "BookTbl";
            Load += BookTbl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView BookDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox quantity;
        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox publisher;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox author;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox bookname;
        private Guna.UI2.WinForms.Guna2TextBox price;
    }
}