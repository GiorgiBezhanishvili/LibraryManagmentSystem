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
            this.BookListTab = new System.Windows.Forms.TabPage();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.BookBorrowTab = new System.Windows.Forms.TabPage();
            this.RegistrationTab = new System.Windows.Forms.TabPage();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.AddCustommerBtn = new System.Windows.Forms.Button();
            this.BookTitleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PublishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialNoTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PersonalNoTB = new System.Windows.Forms.TextBox();
            this.GenreLB = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.BookListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.RegistrationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BookListTab);
            this.tabControl.Controls.Add(this.BookBorrowTab);
            this.tabControl.Controls.Add(this.RegistrationTab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 453);
            this.tabControl.TabIndex = 0;
            // 
            // BookListTab
            // 
            this.BookListTab.Controls.Add(this.BooksDataGridView);
            this.BookListTab.Location = new System.Drawing.Point(4, 22);
            this.BookListTab.Name = "BookListTab";
            this.BookListTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookListTab.Size = new System.Drawing.Size(795, 427);
            this.BookListTab.TabIndex = 0;
            this.BookListTab.Text = "Books In Library";
            this.BookListTab.UseVisualStyleBackColor = true;
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Location = new System.Drawing.Point(60, 57);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.Size = new System.Drawing.Size(673, 318);
            this.BooksDataGridView.TabIndex = 0;
            // 
            // BookBorrowTab
            // 
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
            // BookTitleTB
            // 
            this.BookTitleTB.Location = new System.Drawing.Point(129, 70);
            this.BookTitleTB.Name = "BookTitleTB";
            this.BookTitleTB.Size = new System.Drawing.Size(100, 20);
            this.BookTitleTB.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publish Date";
            // 
            // PublishDatePicker
            // 
            this.PublishDatePicker.Location = new System.Drawing.Point(129, 179);
            this.PublishDatePicker.Name = "PublishDatePicker";
            this.PublishDatePicker.Size = new System.Drawing.Size(200, 20);
            this.PublishDatePicker.TabIndex = 8;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Birthday";
            // 
            // BirthdayDatePicker
            // 
            this.BirthdayDatePicker.Location = new System.Drawing.Point(576, 137);
            this.BirthdayDatePicker.Name = "BirthdayDatePicker";
            this.BirthdayDatePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDatePicker.TabIndex = 20;
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
            // GenreLB
            // 
            this.GenreLB.FormattingEnabled = true;
            this.GenreLB.Location = new System.Drawing.Point(129, 219);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GenreLB.Size = new System.Drawing.Size(120, 69);
            this.GenreLB.TabIndex = 27;
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
            this.BookListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.RegistrationTab.ResumeLayout(false);
            this.RegistrationTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BookListTab;
        private System.Windows.Forms.TabPage BookBorrowTab;
        private System.Windows.Forms.TabPage RegistrationTab;
        private System.Windows.Forms.DataGridView BooksDataGridView;
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
    }
}

