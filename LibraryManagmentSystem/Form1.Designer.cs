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
            this.RegistrationTab = new System.Windows.Forms.TabPage();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.GenreLB = new System.Windows.Forms.ListBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.SerialNoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PublishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookTitleTB = new System.Windows.Forms.TextBox();
            this.AddCustommerBtn = new System.Windows.Forms.Button();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.BooksListDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ReportDGV = new System.Windows.Forms.DataGridView();
            this.BooksCombo = new System.Windows.Forms.ComboBox();
            this.lacel14 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CustommerCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ReturnDateDTP = new System.Windows.Forms.DateTimePicker();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.RbActualReturnDTP = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RbCustommerCombo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.RbBookCombo = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.BookBorrowTab.SuspendLayout();
            this.RegistrationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BookBorrowTab);
            this.tabControl.Controls.Add(this.RegistrationTab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 453);
            this.tabControl.TabIndex = 0;
            // 
            // BookBorrowTab
            // 
            this.BookBorrowTab.Controls.Add(this.ReturnBookBtn);
            this.BookBorrowTab.Controls.Add(this.RbActualReturnDTP);
            this.BookBorrowTab.Controls.Add(this.label16);
            this.BookBorrowTab.Controls.Add(this.label17);
            this.BookBorrowTab.Controls.Add(this.RbCustommerCombo);
            this.BookBorrowTab.Controls.Add(this.label18);
            this.BookBorrowTab.Controls.Add(this.RbBookCombo);
            this.BookBorrowTab.Controls.Add(this.BorrowBtn);
            this.BookBorrowTab.Controls.Add(this.ReturnDateDTP);
            this.BookBorrowTab.Controls.Add(this.label15);
            this.BookBorrowTab.Controls.Add(this.label14);
            this.BookBorrowTab.Controls.Add(this.CustommerCombo);
            this.BookBorrowTab.Controls.Add(this.lacel14);
            this.BookBorrowTab.Controls.Add(this.BooksCombo);
            this.BookBorrowTab.Controls.Add(this.label13);
            this.BookBorrowTab.Controls.Add(this.ReportDGV);
            this.BookBorrowTab.Controls.Add(this.label12);
            this.BookBorrowTab.Controls.Add(this.BooksListDGV);
            this.BookBorrowTab.Location = new System.Drawing.Point(4, 22);
            this.BookBorrowTab.Name = "BookBorrowTab";
            this.BookBorrowTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookBorrowTab.Size = new System.Drawing.Size(795, 427);
            this.BookBorrowTab.TabIndex = 1;
            this.BookBorrowTab.Text = "Borrow Book";
            this.BookBorrowTab.UseVisualStyleBackColor = true;
            // 
            // RegistrationTab
            // 
            this.RegistrationTab.Controls.Add(this.GenerateBtn);
            this.RegistrationTab.Controls.Add(this.GenreLB);
            this.RegistrationTab.Controls.Add(this.label11);
            this.RegistrationTab.Controls.Add(this.PersonalNoTB);
            this.RegistrationTab.Controls.Add(this.label10);
            this.RegistrationTab.Controls.Add(this.AddressTB);
            this.RegistrationTab.Controls.Add(this.label9);
            this.RegistrationTab.Controls.Add(this.EmailTB);
            this.RegistrationTab.Controls.Add(this.BirthdayDatePicker);
            this.RegistrationTab.Controls.Add(this.label8);
            this.RegistrationTab.Controls.Add(this.label7);
            this.RegistrationTab.Controls.Add(this.LastNameTB);
            this.RegistrationTab.Controls.Add(this.label6);
            this.RegistrationTab.Controls.Add(this.NameTB);
            this.RegistrationTab.Controls.Add(this.label5);
            this.RegistrationTab.Controls.Add(this.SerialNoTB);
            this.RegistrationTab.Controls.Add(this.label4);
            this.RegistrationTab.Controls.Add(this.PublishDatePicker);
            this.RegistrationTab.Controls.Add(this.label3);
            this.RegistrationTab.Controls.Add(this.label2);
            this.RegistrationTab.Controls.Add(this.AuthorTB);
            this.RegistrationTab.Controls.Add(this.label1);
            this.RegistrationTab.Controls.Add(this.BookTitleTB);
            this.RegistrationTab.Controls.Add(this.AddCustommerBtn);
            this.RegistrationTab.Controls.Add(this.AddBookBtn);
            this.RegistrationTab.Location = new System.Drawing.Point(4, 22);
            this.RegistrationTab.Name = "RegistrationTab";
            this.RegistrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationTab.Size = new System.Drawing.Size(795, 427);
            this.RegistrationTab.TabIndex = 2;
            this.RegistrationTab.Text = "Registration";
            this.RegistrationTab.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(256, 306);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 28;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // GenreLB
            // 
            this.GenreLB.FormattingEnabled = true;
            this.GenreLB.Location = new System.Drawing.Point(129, 219);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GenreLB.Size = new System.Drawing.Size(120, 69);
            this.GenreLB.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Personal Number";
            // 
            // PersonalNoTB
            // 
            this.PersonalNoTB.Location = new System.Drawing.Point(576, 264);
            this.PersonalNoTB.Name = "PersonalNoTB";
            this.PersonalNoTB.Size = new System.Drawing.Size(100, 20);
            this.PersonalNoTB.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Address";
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(576, 219);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(100, 20);
            this.AddressTB.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(576, 179);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(100, 20);
            this.EmailTB.TabIndex = 21;
            // 
            // BirthdayDatePicker
            // 
            this.BirthdayDatePicker.Location = new System.Drawing.Point(576, 137);
            this.BirthdayDatePicker.Name = "BirthdayDatePicker";
            this.BirthdayDatePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDatePicker.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Name";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(576, 87);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(576, 39);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serial Number";
            // 
            // SerialNoTB
            // 
            this.SerialNoTB.Location = new System.Drawing.Point(129, 306);
            this.SerialNoTB.Name = "SerialNoTB";
            this.SerialNoTB.Size = new System.Drawing.Size(100, 20);
            this.SerialNoTB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genre";
            // 
            // PublishDatePicker
            // 
            this.PublishDatePicker.Location = new System.Drawing.Point(129, 179);
            this.PublishDatePicker.Name = "PublishDatePicker";
            this.PublishDatePicker.Size = new System.Drawing.Size(200, 20);
            this.PublishDatePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publish Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author";
            // 
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(129, 118);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(100, 20);
            this.AuthorTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Title";
            // 
            // BookTitleTB
            // 
            this.BookTitleTB.Location = new System.Drawing.Point(129, 70);
            this.BookTitleTB.Name = "BookTitleTB";
            this.BookTitleTB.Size = new System.Drawing.Size(100, 20);
            this.BookTitleTB.TabIndex = 2;
            // 
            // AddCustommerBtn
            // 
            this.AddCustommerBtn.Location = new System.Drawing.Point(514, 307);
            this.AddCustommerBtn.Name = "AddCustommerBtn";
            this.AddCustommerBtn.Size = new System.Drawing.Size(162, 23);
            this.AddCustommerBtn.TabIndex = 1;
            this.AddCustommerBtn.Text = "Add Custommer";
            this.AddCustommerBtn.UseVisualStyleBackColor = true;
            this.AddCustommerBtn.Click += new System.EventHandler(this.AddCustommerBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(129, 348);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 0;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BooksListDGV
            // 
            this.BooksListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksListDGV.Location = new System.Drawing.Point(82, 59);
            this.BooksListDGV.Name = "BooksListDGV";
            this.BooksListDGV.Size = new System.Drawing.Size(244, 150);
            this.BooksListDGV.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Books List";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(670, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Report";
            // 
            // ReportDGV
            // 
            this.ReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDGV.Location = new System.Drawing.Point(469, 59);
            this.ReportDGV.Name = "ReportDGV";
            this.ReportDGV.Size = new System.Drawing.Size(240, 150);
            this.ReportDGV.TabIndex = 2;
            // 
            // BooksCombo
            // 
            this.BooksCombo.FormattingEnabled = true;
            this.BooksCombo.Location = new System.Drawing.Point(85, 256);
            this.BooksCombo.Name = "BooksCombo";
            this.BooksCombo.Size = new System.Drawing.Size(200, 21);
            this.BooksCombo.TabIndex = 4;
            // 
            // lacel14
            // 
            this.lacel14.AutoSize = true;
            this.lacel14.Location = new System.Drawing.Point(24, 259);
            this.lacel14.Name = "lacel14";
            this.lacel14.Size = new System.Drawing.Size(37, 13);
            this.lacel14.TabIndex = 5;
            this.lacel14.Text = "Books";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Custommers";
            // 
            // CustommerCombo
            // 
            this.CustommerCombo.FormattingEnabled = true;
            this.CustommerCombo.Location = new System.Drawing.Point(85, 296);
            this.CustommerCombo.Name = "CustommerCombo";
            this.CustommerCombo.Size = new System.Drawing.Size(200, 21);
            this.CustommerCombo.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Return Date";
            // 
            // ReturnDateDTP
            // 
            this.ReturnDateDTP.Location = new System.Drawing.Point(85, 335);
            this.ReturnDateDTP.Name = "ReturnDateDTP";
            this.ReturnDateDTP.Size = new System.Drawing.Size(200, 20);
            this.ReturnDateDTP.TabIndex = 10;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Location = new System.Drawing.Point(139, 377);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(75, 23);
            this.BorrowBtn.TabIndex = 11;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.Location = new System.Drawing.Point(563, 372);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBookBtn.TabIndex = 18;
            this.ReturnBookBtn.Text = "Book Return";
            this.ReturnBookBtn.UseVisualStyleBackColor = true;
            // 
            // RbActualReturnDTP
            // 
            this.RbActualReturnDTP.Location = new System.Drawing.Point(509, 330);
            this.RbActualReturnDTP.Name = "RbActualReturnDTP";
            this.RbActualReturnDTP.Size = new System.Drawing.Size(200, 20);
            this.RbActualReturnDTP.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(432, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Return Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(432, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Custommers";
            // 
            // RbCustommerCombo
            // 
            this.RbCustommerCombo.FormattingEnabled = true;
            this.RbCustommerCombo.Location = new System.Drawing.Point(509, 291);
            this.RbCustommerCombo.Name = "RbCustommerCombo";
            this.RbCustommerCombo.Size = new System.Drawing.Size(200, 21);
            this.RbCustommerCombo.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(448, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Books";
            // 
            // RbBookCombo
            // 
            this.RbBookCombo.FormattingEnabled = true;
            this.RbBookCombo.Location = new System.Drawing.Point(509, 251);
            this.RbBookCombo.Name = "RbBookCombo";
            this.RbBookCombo.Size = new System.Drawing.Size(200, 21);
            this.RbBookCombo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Library Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.BookBorrowTab.ResumeLayout(false);
            this.BookBorrowTab.PerformLayout();
            this.RegistrationTab.ResumeLayout(false);
            this.RegistrationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BookBorrowTab;
        private System.Windows.Forms.TabPage RegistrationTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialNoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker PublishDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookTitleTB;
        private System.Windows.Forms.Button AddCustommerBtn;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PersonalNoTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.DateTimePicker BirthdayDatePicker;
        private System.Windows.Forms.ListBox GenreLB;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.DateTimePicker ReturnDateDTP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CustommerCombo;
        private System.Windows.Forms.Label lacel14;
        private System.Windows.Forms.ComboBox BooksCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ReportDGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView BooksListDGV;
        private System.Windows.Forms.Button ReturnBookBtn;
        private System.Windows.Forms.DateTimePicker RbActualReturnDTP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox RbCustommerCombo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox RbBookCombo;
    }
}

