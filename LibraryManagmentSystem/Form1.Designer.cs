namespace LibraryManagmentSystem
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.BookBorrowTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AuthorCombo = new System.Windows.Forms.ComboBox();
            this.AuthorLBL = new System.Windows.Forms.Label();
            this.BooksCombo = new System.Windows.Forms.ComboBox();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.lacel14 = new System.Windows.Forms.Label();
            this.ReturnDateDTP = new System.Windows.Forms.DateTimePicker();
            this.CustommerCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BooksListDGV = new System.Windows.Forms.DataGridView();
            this.AddBookTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AddAuthLastNameTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AddAuthorBtn = new System.Windows.Forms.Button();
            this.AddAuthNameTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AddGenreBtn = new System.Windows.Forms.Button();
            this.AddGenreTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddBookAuthorCombo = new System.Windows.Forms.ComboBox();
            this.GenreLB = new System.Windows.Forms.ListBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.BookTitleTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialNoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PublishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCustommerTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PersonalNoTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.BirthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AddCustommerBtn = new System.Windows.Forms.Button();
            this.CustommersDGV = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.ReturnBookSNTB = new System.Windows.Forms.TextBox();
            this.ReturnBookNameLbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.BookBorrowTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListDGV)).BeginInit();
            this.AddBookTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AddCustommerTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustommersDGV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BookBorrowTab);
            this.tabControl.Controls.Add(this.AddBookTab);
            this.tabControl.Controls.Add(this.AddCustommerTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 453);
            this.tabControl.TabIndex = 0;
            // 
            // BookBorrowTab
            // 
            this.BookBorrowTab.BackColor = System.Drawing.Color.YellowGreen;
            this.BookBorrowTab.Controls.Add(this.groupBox4);
            this.BookBorrowTab.Controls.Add(this.groupBox3);
            this.BookBorrowTab.Controls.Add(this.BooksListDGV);
            this.BookBorrowTab.Location = new System.Drawing.Point(4, 22);
            this.BookBorrowTab.Name = "BookBorrowTab";
            this.BookBorrowTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookBorrowTab.Size = new System.Drawing.Size(795, 427);
            this.BookBorrowTab.TabIndex = 1;
            this.BookBorrowTab.Text = "Borrow Book";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox4.Controls.Add(this.SearchBtn);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.ReturnBookNameLbl);
            this.groupBox4.Controls.Add(this.ReturnBookSNTB);
            this.groupBox4.Controls.Add(this.ReturnBtn);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(6, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 177);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Return Book";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(133, 121);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "Return Book";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Serial Number";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox3.Controls.Add(this.ShowBtn);
            this.groupBox3.Controls.Add(this.AuthorCombo);
            this.groupBox3.Controls.Add(this.AuthorLBL);
            this.groupBox3.Controls.Add(this.BooksCombo);
            this.groupBox3.Controls.Add(this.BorrowBtn);
            this.groupBox3.Controls.Add(this.lacel14);
            this.groupBox3.Controls.Add(this.ReturnDateDTP);
            this.groupBox3.Controls.Add(this.CustommerCombo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 232);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrow Book";
            // 
            // AuthorCombo
            // 
            this.AuthorCombo.FormattingEnabled = true;
            this.AuthorCombo.Location = new System.Drawing.Point(79, 34);
            this.AuthorCombo.Name = "AuthorCombo";
            this.AuthorCombo.Size = new System.Drawing.Size(200, 21);
            this.AuthorCombo.TabIndex = 12;
            // 
            // AuthorLBL
            // 
            this.AuthorLBL.AutoSize = true;
            this.AuthorLBL.Location = new System.Drawing.Point(18, 37);
            this.AuthorLBL.Name = "AuthorLBL";
            this.AuthorLBL.Size = new System.Drawing.Size(38, 13);
            this.AuthorLBL.TabIndex = 13;
            this.AuthorLBL.Text = "Author";
            // 
            // BooksCombo
            // 
            this.BooksCombo.FormattingEnabled = true;
            this.BooksCombo.Location = new System.Drawing.Point(79, 74);
            this.BooksCombo.Name = "BooksCombo";
            this.BooksCombo.Size = new System.Drawing.Size(200, 21);
            this.BooksCombo.TabIndex = 4;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Location = new System.Drawing.Point(133, 195);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(75, 23);
            this.BorrowBtn.TabIndex = 11;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // lacel14
            // 
            this.lacel14.AutoSize = true;
            this.lacel14.Location = new System.Drawing.Point(18, 77);
            this.lacel14.Name = "lacel14";
            this.lacel14.Size = new System.Drawing.Size(37, 13);
            this.lacel14.TabIndex = 5;
            this.lacel14.Text = "Books";
            // 
            // ReturnDateDTP
            // 
            this.ReturnDateDTP.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ReturnDateDTP.Location = new System.Drawing.Point(79, 153);
            this.ReturnDateDTP.MinDate = new System.DateTime(2020, 8, 14, 0, 0, 0, 0);
            this.ReturnDateDTP.Name = "ReturnDateDTP";
            this.ReturnDateDTP.Size = new System.Drawing.Size(200, 20);
            this.ReturnDateDTP.TabIndex = 10;
            this.ReturnDateDTP.Value = new System.DateTime(2020, 8, 14, 0, 0, 0, 0);
            // 
            // CustommerCombo
            // 
            this.CustommerCombo.FormattingEnabled = true;
            this.CustommerCombo.Location = new System.Drawing.Point(79, 114);
            this.CustommerCombo.Name = "CustommerCombo";
            this.CustommerCombo.Size = new System.Drawing.Size(200, 21);
            this.CustommerCombo.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Return Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Custommers";
            // 
            // BooksListDGV
            // 
            this.BooksListDGV.AllowUserToAddRows = false;
            this.BooksListDGV.AllowUserToDeleteRows = false;
            this.BooksListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksListDGV.Location = new System.Drawing.Point(359, 6);
            this.BooksListDGV.Name = "BooksListDGV";
            this.BooksListDGV.ReadOnly = true;
            this.BooksListDGV.Size = new System.Drawing.Size(430, 415);
            this.BooksListDGV.TabIndex = 0;
            // 
            // AddBookTab
            // 
            this.AddBookTab.BackColor = System.Drawing.Color.YellowGreen;
            this.AddBookTab.Controls.Add(this.groupBox6);
            this.AddBookTab.Controls.Add(this.groupBox5);
            this.AddBookTab.Controls.Add(this.groupBox2);
            this.AddBookTab.Location = new System.Drawing.Point(4, 22);
            this.AddBookTab.Name = "AddBookTab";
            this.AddBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddBookTab.Size = new System.Drawing.Size(795, 427);
            this.AddBookTab.TabIndex = 2;
            this.AddBookTab.Text = "Add Book & etc";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox6.Controls.Add(this.AddAuthLastNameTB);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.AddAuthorBtn);
            this.groupBox6.Controls.Add(this.AddAuthNameTB);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(438, 216);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(351, 205);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Author";
            // 
            // AddAuthLastNameTB
            // 
            this.AddAuthLastNameTB.Location = new System.Drawing.Point(81, 107);
            this.AddAuthLastNameTB.Name = "AddAuthLastNameTB";
            this.AddAuthLastNameTB.Size = new System.Drawing.Size(217, 20);
            this.AddAuthLastNameTB.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Last Name";
            // 
            // AddAuthorBtn
            // 
            this.AddAuthorBtn.Location = new System.Drawing.Point(140, 147);
            this.AddAuthorBtn.Name = "AddAuthorBtn";
            this.AddAuthorBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorBtn.TabIndex = 9;
            this.AddAuthorBtn.Text = "Add Author";
            this.AddAuthorBtn.UseVisualStyleBackColor = true;
            this.AddAuthorBtn.Click += new System.EventHandler(this.AddAuthorBtn_Click);
            // 
            // AddAuthNameTB
            // 
            this.AddAuthNameTB.Location = new System.Drawing.Point(81, 60);
            this.AddAuthNameTB.Name = "AddAuthNameTB";
            this.AddAuthNameTB.Size = new System.Drawing.Size(217, 20);
            this.AddAuthNameTB.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox5.Controls.Add(this.AddGenreBtn);
            this.groupBox5.Controls.Add(this.AddGenreTB);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(438, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 205);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Genre";
            // 
            // AddGenreBtn
            // 
            this.AddGenreBtn.Location = new System.Drawing.Point(140, 139);
            this.AddGenreBtn.Name = "AddGenreBtn";
            this.AddGenreBtn.Size = new System.Drawing.Size(75, 23);
            this.AddGenreBtn.TabIndex = 6;
            this.AddGenreBtn.Text = "Add Genre";
            this.AddGenreBtn.UseVisualStyleBackColor = true;
            this.AddGenreBtn.Click += new System.EventHandler(this.AddGenreBtn_Click);
            // 
            // AddGenreTB
            // 
            this.AddGenreTB.Location = new System.Drawing.Point(87, 93);
            this.AddGenreTB.Name = "AddGenreTB";
            this.AddGenreTB.Size = new System.Drawing.Size(217, 20);
            this.AddGenreTB.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Genre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Controls.Add(this.AddBookAuthorCombo);
            this.groupBox2.Controls.Add(this.GenreLB);
            this.groupBox2.Controls.Add(this.GenerateBtn);
            this.groupBox2.Controls.Add(this.AddBookBtn);
            this.groupBox2.Controls.Add(this.BookTitleTB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SerialNoTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PublishDatePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 415);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Book";
            // 
            // AddBookAuthorCombo
            // 
            this.AddBookAuthorCombo.FormattingEnabled = true;
            this.AddBookAuthorCombo.Location = new System.Drawing.Point(116, 100);
            this.AddBookAuthorCombo.Name = "AddBookAuthorCombo";
            this.AddBookAuthorCombo.Size = new System.Drawing.Size(217, 21);
            this.AddBookAuthorCombo.TabIndex = 29;
            // 
            // GenreLB
            // 
            this.GenreLB.FormattingEnabled = true;
            this.GenreLB.Location = new System.Drawing.Point(116, 255);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GenreLB.Size = new System.Drawing.Size(217, 95);
            this.GenreLB.TabIndex = 27;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(258, 205);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 28;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(116, 373);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 0;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BookTitleTB
            // 
            this.BookTitleTB.Location = new System.Drawing.Point(116, 52);
            this.BookTitleTB.Name = "BookTitleTB";
            this.BookTitleTB.Size = new System.Drawing.Size(217, 20);
            this.BookTitleTB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Title";
            // 
            // SerialNoTB
            // 
            this.SerialNoTB.Location = new System.Drawing.Point(116, 207);
            this.SerialNoTB.Name = "SerialNoTB";
            this.SerialNoTB.Size = new System.Drawing.Size(136, 20);
            this.SerialNoTB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author";
            // 
            // PublishDatePicker
            // 
            this.PublishDatePicker.Location = new System.Drawing.Point(116, 149);
            this.PublishDatePicker.MaxDate = new System.DateTime(2020, 8, 14, 0, 0, 0, 0);
            this.PublishDatePicker.Name = "PublishDatePicker";
            this.PublishDatePicker.Size = new System.Drawing.Size(217, 20);
            this.PublishDatePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publish Date";
            // 
            // AddCustommerTab
            // 
            this.AddCustommerTab.BackColor = System.Drawing.Color.YellowGreen;
            this.AddCustommerTab.Controls.Add(this.groupBox1);
            this.AddCustommerTab.Controls.Add(this.CustommersDGV);
            this.AddCustommerTab.Location = new System.Drawing.Point(4, 22);
            this.AddCustommerTab.Name = "AddCustommerTab";
            this.AddCustommerTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddCustommerTab.Size = new System.Drawing.Size(795, 427);
            this.AddCustommerTab.TabIndex = 3;
            this.AddCustommerTab.Text = "Add  Custommer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PersonalNoTB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.AddressTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.EmailTB);
            this.groupBox1.Controls.Add(this.BirthdayDatePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LastNameTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.AddCustommerBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Custommer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Personal Number";
            // 
            // PersonalNoTB
            // 
            this.PersonalNoTB.Location = new System.Drawing.Point(99, 269);
            this.PersonalNoTB.Name = "PersonalNoTB";
            this.PersonalNoTB.Size = new System.Drawing.Size(200, 20);
            this.PersonalNoTB.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Address";
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(99, 227);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(200, 20);
            this.AddressTB.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Email";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(99, 187);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(200, 20);
            this.EmailTB.TabIndex = 34;
            // 
            // BirthdayDatePicker
            // 
            this.BirthdayDatePicker.Location = new System.Drawing.Point(99, 145);
            this.BirthdayDatePicker.MaxDate = new System.DateTime(2020, 8, 14, 6, 55, 37, 0);
            this.BirthdayDatePicker.Name = "BirthdayDatePicker";
            this.BirthdayDatePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDatePicker.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Last Name";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(99, 95);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(200, 20);
            this.LastNameTB.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(99, 47);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 20);
            this.NameTB.TabIndex = 28;
            // 
            // AddCustommerBtn
            // 
            this.AddCustommerBtn.Location = new System.Drawing.Point(99, 341);
            this.AddCustommerBtn.Name = "AddCustommerBtn";
            this.AddCustommerBtn.Size = new System.Drawing.Size(200, 23);
            this.AddCustommerBtn.TabIndex = 27;
            this.AddCustommerBtn.Text = "Add Custommer";
            this.AddCustommerBtn.UseVisualStyleBackColor = true;
            this.AddCustommerBtn.Click += new System.EventHandler(this.AddCustommerBtn_Click_1);
            // 
            // CustommersDGV
            // 
            this.CustommersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustommersDGV.Location = new System.Drawing.Point(384, 6);
            this.CustommersDGV.Name = "CustommersDGV";
            this.CustommersDGV.Size = new System.Drawing.Size(405, 415);
            this.CustommersDGV.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 427);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Report";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.CadetBlue;
            this.label18.Location = new System.Drawing.Point(336, 3);
            this.label18.MaximumSize = new System.Drawing.Size(150, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 60);
            this.label18.TabIndex = 1;
            this.label18.Text = "Report";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(783, 355);
            this.dataGridView2.TabIndex = 0;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(286, 34);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(55, 21);
            this.ShowBtn.TabIndex = 14;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // ReturnBookSNTB
            // 
            this.ReturnBookSNTB.Location = new System.Drawing.Point(79, 51);
            this.ReturnBookSNTB.Name = "ReturnBookSNTB";
            this.ReturnBookSNTB.Size = new System.Drawing.Size(200, 20);
            this.ReturnBookSNTB.TabIndex = 9;
            // 
            // ReturnBookNameLbl
            // 
            this.ReturnBookNameLbl.AutoSize = true;
            this.ReturnBookNameLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookNameLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnBookNameLbl.Location = new System.Drawing.Point(99, 90);
            this.ReturnBookNameLbl.Name = "ReturnBookNameLbl";
            this.ReturnBookNameLbl.Size = new System.Drawing.Size(0, 16);
            this.ReturnBookNameLbl.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(88, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Write Down Serial Number of Book";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(286, 50);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(55, 21);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Library Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.BookBorrowTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListDGV)).EndInit();
            this.AddBookTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AddCustommerTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustommersDGV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BookBorrowTab;
        private System.Windows.Forms.TabPage AddBookTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialNoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker PublishDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookTitleTB;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.ListBox GenreLB;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.DateTimePicker ReturnDateDTP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CustommerCombo;
        private System.Windows.Forms.Label lacel14;
        private System.Windows.Forms.ComboBox BooksCombo;
        private System.Windows.Forms.DataGridView BooksListDGV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox AuthorCombo;
        private System.Windows.Forms.Label AuthorLBL;
        private System.Windows.Forms.TabPage AddCustommerTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PersonalNoTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.DateTimePicker BirthdayDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button AddCustommerBtn;
        private System.Windows.Forms.DataGridView CustommersDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox AddAuthLastNameTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button AddAuthorBtn;
        private System.Windows.Forms.TextBox AddAuthNameTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button AddGenreBtn;
        private System.Windows.Forms.TextBox AddGenreTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox AddBookAuthorCombo;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Label ReturnBookNameLbl;
        private System.Windows.Forms.TextBox ReturnBookSNTB;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label19;
    }
}

