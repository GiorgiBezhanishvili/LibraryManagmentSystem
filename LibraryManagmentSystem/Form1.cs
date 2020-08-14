using LibraryManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeepAutomation.Barcode.Crystal;
using System.Security.Authentication.ExtendedProtection;
using System.Net.Mime;

namespace LibraryManagmentSystem
{
    public partial class Form1 : Form
    {
        private int infoTransferBookId = 0; // ***
        private int infoTransferBorrowId = 0; //**
        private int infoTransferCustommerId = 0; //**
        private int infoTransferGenreId = 0; //**
        private int infoTransferAuthorId = 0; //**
        //private int infoTransferDeleteBookId = 0; //**

        private readonly LibraryDataContext context;
        public Form1()
        {
            context = new LibraryDataContext();
            InitializeComponent();
            BooksData();
            GetGenres();
            AuthorsInCombo();
            CustommersInCombo();
            GetCustommersData();
            GetReportData();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            var authorId = (int)AuthorCombo.SelectedValue;

            // fill Books ComboBox
            BooksInCombo(authorId);
        }

        #region Helper Functions

        // for Borrow Book Tab && Add Book Tab
        private void AuthorsInCombo()
        {
            var authors = (from a in context.Authors
                           select a);

            AuthorCombo.DisplayMember = "FullName";
            AuthorCombo.ValueMember = "Id";
            AuthorCombo.DataSource = authors;

            AddBookAuthorCombo.DisplayMember = "FullName";
            AddBookAuthorCombo.ValueMember = "Id";
            AddBookAuthorCombo.DataSource = authors;
        }

        // for Borrow Book Tab
        private void BooksInCombo(int authorId)
        {
            var books = (from bk in context.Books
                         where bk.AuthorId == authorId && bk.IsActive == true
                         select bk);

            BooksCombo.DisplayMember = "BookTitle";
            BooksCombo.ValueMember = "SerialNumber";
            BooksCombo.DataSource = books;
        }


        // for Borrow Book Tab 
        private void CustommersInCombo()
        {
            var cust = (from c in context.Custommers
                        select new
                        {
                            FullName = $"{c.Name} {c.LastName}",
                            c.PersonalNumber
                        });

            CustommerCombo.DisplayMember = "FullName";
            CustommerCombo.ValueMember = "PersonalNumber";
            CustommerCombo.DataSource = cust;

        }

        // for Add Book Tab
        private void GetGenres()
        {
            var genres = (from g in context.Genres
                          select g);

            GenreLB.DisplayMember = "Genre1";
            GenreLB.ValueMember = "Id";
            GenreLB.DataSource = genres;

            //foreach (var item in genres)
            //{
            //    GenreLB.Items.Add(item.Genre1);
            //}
        }

        #endregion of Helper Functions


        #region Borrow Book Tab

        // Borrow Book To Someone
        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                BooksCombo.SelectedValue.ToString();
            }
            catch (Exception) 
            {
                MessageBox.Show("გთხოვთ მონიშნოთ ველი Books სიაში");
                return;
            }

            var bookSerialNo = BooksCombo.SelectedValue.ToString();


            try
            {
                CustommerCombo.SelectedValue.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("გთხოვთ მონიშნოთ ველი Custommers სიაში");
                return;
            }

            var custPersonalNo = CustommerCombo.SelectedValue.ToString();


            // finding IDs of current object to fill Borrow Table

            var bookId = (from bk in context.Books
                          where bk.SerialNumber == bookSerialNo && bk.IsActive == true
                          select bk.Id).Single();
            var customr = (from cust in context.Custommers
                          where cust.PersonalNumber == custPersonalNo
                          select new {
                                cust.Id,
                                FullName = $"{cust.Name} {cust.LastName}",
                                cust.BirthDay
                          }).FirstOrDefault();

            if ((DateTime.Today.Year - customr.BirthDay.Year) >= 16)
            {
                if ((DateTime.Today.Month - customr.BirthDay.Month) >= 0)
                {
                    if ((DateTime.Today.Day - customr.BirthDay.Day) < 0)
                    {
                        MessageBox.Show("16 წლის ჩათვლით არ გაიცემა წიგნები!");
                        return;
                    }
                }
                else 
                {
                    MessageBox.Show("16 წლის ჩათვლით არ გაიცემა წიგნები!");
                    return;
                }
            }
            else 
            {
                MessageBox.Show("16 წლის ჩათვლით არ გაიცემა წიგნები!");
                return;
            }

            var returnDate = ReturnDateDTP.Value;

            if (returnDate.Date == DateTime.Today) 
            {
                MessageBox.Show("ჯიგარო ამის წამკითხველი შენ არ ხარ!\n" +
                    "თუ გინდა გაგატანო წიგნი, მაშინ მინიმუმ ხვალინდელი დღე მონიშნე )))");
                return;
            }


            var borrowDate = DateTime.Today;


            var borrow = new Borrow
            {
                CustomerId = customr.Id,
                BookId = bookId,
                ReturnDate = returnDate,
                OrderDate = borrowDate,
            };

            var book = (from b in context.Books
                        where b.Id == bookId
                        select b).Single();

            book.IsActive = false;
            context.Borrows.InsertOnSubmit(borrow);

            context.SubmitChanges();
            BooksData();
            GetReportData();
            MessageBox.Show($"წიგნი გაიტანა {customr.FullName}");
        }

        // for Load Books Data in Combo box
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            var authorId = (int)AuthorCombo.SelectedValue;

            // fill Books ComboBox
            BooksInCombo(authorId);
        }


        // Books in GridView
        private void BooksData()
        {
            var Books = (
                from book in context.Books
                join author in context.Authors on book.AuthorId equals author.Id
                orderby book.BookTitle ascending
                select new BookDTO
                {
                    Id = book.Id,
                    BookTitle = book.BookTitle,
                    Author = author.FullName,
                    SerialNumber = book.SerialNumber,
                    PublicationDate = book.PublicationDate,
                    IsActive = book.IsActive
                }).AsQueryable();

            var FinalData = new List<BookDTO>();

            foreach (var book in Books)
            {
                var Genres = (from genre in context.Genres
                              join gob in context.GenresOfBooks on genre.Id equals gob.GenreId
                              where gob.BookId == book.Id
                              select genre.Genre1);

                string allGenres = "";

                foreach (var genre in Genres)
                {
                    allGenres = allGenres + genre + " ";
                }

                //Books.Where(e => e.Id == book.Id).FirstOrDefault().Genres = allGenres;
                book.Genres = allGenres;
                FinalData.Add(book);
            }


            

            BooksListDGV.DataSource = FinalData;
            BooksListDGV.Columns["Id"].Visible = false;
        }

        // Return Book

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // serial number of book
            var serialNo = ReturnBookSNTB.Text;
            if (serialNo == "" || ReturnBookSNTB.Text.Length != 13) 
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ წიგნის სერიული ნომერი! \n" +
                    "რომელიც შედგება რიცხვებისაგან და მისი ზომა 13-ის ტოლია");
                return;
            }

            
            // find Book Id that belong above serial number
            var thatBook = (from tb in context.Books
                            where tb.SerialNumber == serialNo
                            select new 
                            {
                                tb.Id,
                                tb.BookTitle
                            }).FirstOrDefault();

            if (thatBook == null) 
            {
                MessageBox.Show("ასეთი წიგნი ბიბლიოთეკაში არ გვაქ საერთოდ!");
                return;
            }



            // find if exist or not this book id in Borrow table
            // if exist then we will retrieve Id of borrower if not then throws an exception
            // message
            var borrowerId = (from bo in context.Borrows
                           where bo.BookId == thatBook.Id && bo.ActualReturnDate == null
                           select new 
                           {
                               bo.CustomerId,
                               bo.Id
                           }).FirstOrDefault();

            if (borrowerId == null) 
            {
                MessageBox.Show("მომხმარებელს ეს წიგნი არ გაუტანია");
                return;
            }

            var custommerName = (from cust in context.Custommers
                                 where cust.Id == borrowerId.CustomerId
                                 select new
                                 {
                                     FullName = $"{cust.Name} {cust.LastName}"
                                 }).FirstOrDefault();

            // Displaying data on Lable
            ReturnBookNameLbl.Text = $"{thatBook.BookTitle} [{custommerName.FullName}]";

            infoTransferBookId = thatBook.Id;
            infoTransferBorrowId = borrowerId.Id;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (infoTransferBookId == 0 || infoTransferBorrowId == 0) 
            {
                MessageBox.Show("არავალიდური ინფორმაცია");
                return;
            }

            var book = (from b in context.Books
                        where b.Id == infoTransferBookId
                        select b).FirstOrDefault();
            if (book.IsActive) 
            {
                MessageBox.Show("Somting Strange is Going on! )) \n" +
                    "ეს ველი არ შესრულდება, მაგრამ მართლა რომ შესრულდეს \n" +
                    "მაგ შემთხვევისთვის მაქვს ეს ტესტი");
            }

            var actualReturnDate = DateTime.Today;

            var borrow = (from bo in context.Borrows
                          where bo.Id == infoTransferBorrowId
                          select bo).FirstOrDefault();

            if (borrow.ActualReturnDate != null)
            {
                MessageBox.Show("Somting Strange is Going on! )) \n" +
                    "ეს ველი არ შესრულდება, მაგრამ მართლა რომ შესრულდეს \n" +
                    "მაგ შემთხვევისთვის მაქვს ეს ტესტი");
            }

            book.IsActive = true;
            borrow.ActualReturnDate = actualReturnDate;

            context.SubmitChanges();

            BooksData();
            GetReportData();
            ReturnBookSNTB.Clear();
            ReturnBookNameLbl.ResetText();
            infoTransferBookId = 0;
            infoTransferBorrowId = 0;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ReturnBookNameLbl.Text = "";
            ReturnBookSNTB.Clear();
            infoTransferBookId = 0;
            infoTransferBorrowId = 0;
        }

        #endregion of Borrow Book Tab



        #region Add Book Tab

        private void AddBookBtn_Click(object sender, EventArgs e)
        {

            // Valdation Check

            if (BookTitleTB.Text == "") 
            {
                MessageBox.Show("მიუთითოთ წიგნის სათაური");
                return;
            }


            if (PublishDatePicker.Value.Date == DateTime.Today) 
            {
                MessageBox.Show("შანსი არაა :)");
                return;
            }

            if (SerialNoTB.Text == "" || SerialNoTB.Text.Length != 13) 
            {
                MessageBox.Show("შეიყვანეთ წიგნის სერიული ნომერი \n" +
                    "მისი სიგრძე არის 13-ის ტოლი");
                return;
            }


            var bookMatch = (from bm in context.Books
                             where bm.SerialNumber == SerialNoTB.Text
                             select bm).FirstOrDefault();
            if (bookMatch != null) 
            {
                MessageBox.Show("წიგნი მსგავსი სერიული ნომრით უკვე არსებობს!");
                return;
            }

            if (GenreLB.SelectedItems.Count == 0)
            {
                MessageBox.Show("გთხოვთ აირჩიეთ ჟანრი");
                return;
            }

            // adding data in Books Table
            var genres = new List<string>();

            foreach (Genre item in GenreLB.SelectedItems)
            {
                genres.Add(item.Genre1);
            }

            var book = new BookVM
            {
                BookTitle = BookTitleTB.Text,
                Author = (int)AddBookAuthorCombo.SelectedValue,
                PublishDate = PublishDatePicker.Value,
                SerialNumber = SerialNoTB.Text,
                Genres = genres,
                IsActive = true
                
            };


            var bok = new Book
            {
                BookTitle = book.BookTitle,
                AuthorId = book.Author,
                    PublicationDate = book.PublishDate,
                    SerialNumber = book.SerialNumber,
                    IsActive = book.IsActive
                    
                };

                context.Books.InsertOnSubmit(bok);
                context.SubmitChanges();

                // adding data in GenresOfBooks

                var bookId = (from id in context.Books
                              where id.SerialNumber == book.SerialNumber
                              select id.Id).FirstOrDefault();

                var genreIds = new List<int>();

                foreach (var item in book.Genres)
                {
                    var Ids = (from gid in context.Genres
                               where gid.Genre1 == item
                               select gid.Id).FirstOrDefault();
                    genreIds.Add(Ids);
                }


                foreach (var item in genreIds)
                {
                    var bookGenres = new GenresOfBook
                    {
                        BookId = bookId,
                        GenreId = item
                    };
                    context.GenresOfBooks.InsertOnSubmit(bookGenres);
                }
                context.SubmitChanges();


                BookTitleTB.Clear();
                GenreLB.ClearSelected();
                SerialNoTB.Clear();

                BooksData();

                MessageBox.Show("წიგნი დაემატა წარმატებით");
            
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            var chars = "0123456789";
            var stringChars = new char[13];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            SerialNoTB.Text = finalString;
        }

        private void AddGenreBtn_Click(object sender, EventArgs e)
        {
            if (AddGenreTB.Text == "") 
            {
                MessageBox.Show("შეავსეთ ჟანრების ველი!");
                return;
            }

            var genreName = AddGenreTB.Text;

            var genreMatch = (from gm in context.Genres
                              where gm.Genre1 == genreName
                              select gm).FirstOrDefault();
            if (genreMatch != null) 
            {
                MessageBox.Show("მსგავსი ჟანრი უკვე ბაზაშია");
            }

            var genres = new Genre
            {
                Genre1 = genreName
            };

            context.Genres.InsertOnSubmit(genres);
            context.SubmitChanges();

            MessageBox.Show("ჟანრი წარატებით დაემატა");
            AddGenreTB.Clear();
            GetGenres();
            

        }

        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AddAuthNameTB.Text == "")
            {
                MessageBox.Show("შეავსეთ სახელის ველი!");
                return;
            }

            if (AddAuthLastNameTB.Text == "")
            {
                MessageBox.Show("შეავსეთ გვარის ველი!");
                return;
            }

            var fullName = $"{AddAuthNameTB.Text} {AddAuthLastNameTB.Text}";

            var authorMatch = (from am in context.Authors
                               where am.FullName == fullName
                               select am).FirstOrDefault();

            if (authorMatch != null) 
            {
                MessageBox.Show("ასეთი ავტორი უკვე ბაზაშია");
                return;
            }

            var authors = new Author
            {
                FullName = fullName
            };

            context.Authors.InsertOnSubmit(authors);
            context.SubmitChanges();

            MessageBox.Show("ავტორი წარმატებით დაემატა");
            AuthorsInCombo();
            AddAuthNameTB.Clear();
            AddAuthLastNameTB.Clear();
        }

        #endregion of Add Book Tab



        #region Add Custommer Tab

        private void AddCustommerBtn_Click_1(object sender, EventArgs e)
        {
            // Validations

            if (NameTB.Text == "") 
            {
                MessageBox.Show("შეავსეთ სახელის ველი");
                return;
            }

            if (LastNameTB.Text == "")
            {
                MessageBox.Show("შეავსეთ გვარის ველი");
                return;
            }

            if (BirthdayDatePicker.Value.Date == DateTime.Today)
            {
                MessageBox.Show("ღადაობ?");
                return;
            }

            if (EmailTB.Text == "")
            {
                MessageBox.Show("შეავსეთ მეილის ველი");
                return;
            }
            
            // validating email
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(EmailTB.Text))
            {
                MessageBox.Show("მეილის არასწორი ფორმატი");
                return;
            }

            if (AddressTB.Text == "")
            {
                MessageBox.Show("შეავსეთ მისამართის ველი");
                return;
            }

            if (PersonalNoTB.Text == "" || PersonalNoTB.Text.Length != 11)
            {
                MessageBox.Show("შეავსეთ პირადი ნორმის ველი \n" +
                    "პირადი ნომრის ველი უნდა შედგებოდეს რიცხვებისგან \n" +
                    "და უნდა შეიცავდეს 11 ციფრს");
                return;
            }

            var personMatch = (from pm in context.Custommers
                               where pm.PersonalNumber == PersonalNoTB.Text
                               select pm).FirstOrDefault();
            if (personMatch != null) 
            {
                MessageBox.Show("მომხმარებელი მსგავსი პირადი ნომრით უკვე რეგისტრირებულია");
                return;
            }



            var custommer = new CustommerVM
            {
                Name = NameTB.Text,
                LastName = LastNameTB.Text,
                Birthday = BirthdayDatePicker.Value,
                Email = EmailTB.Text,
                Address = AddressTB.Text,
                PersonalNumber = PersonalNoTB.Text
            };

            var cust = new Custommer
            {
                Name = custommer.Name,
                LastName = custommer.LastName,
                BirthDay = custommer.Birthday,
                Email = custommer.Email,
                Address = custommer.Address,
                PersonalNumber = custommer.PersonalNumber
            };
            context.Custommers.InsertOnSubmit(cust);


            context.SubmitChanges();

            NameTB.Clear();
            LastNameTB.Clear();
            EmailTB.Clear();
            AddressTB.Clear();
            PersonalNoTB.Clear();

            MessageBox.Show("მომხმარებელი დაემატა წარმატებით");

            GetCustommersData();
        }

        private void GetCustommersData() 
        {
            var custommers = (from c in context.Custommers
                              select c);
            CustommersDGV.DataSource = custommers;
            CustommersDGV.Columns["Id"].Visible = false;
        }

        #endregion of Add Custommer Tab


        #region Report Tab


        private void GetReportData() 
        {
            var reportData = (from book in context.Books
                              join borrow in context.Borrows on book.Id equals borrow.BookId
                              join custommer in context.Custommers on borrow.CustomerId equals custommer.Id
                              select new 
                              {
                                  BookTitle = book.BookTitle,
                                  Custommer = $"{custommer.Name} {custommer.LastName}",
                                  OrderDate = borrow.OrderDate,
                                  EstimatedReturnDate = borrow.ReturnDate,
                                  ActualReturnDate = borrow.ActualReturnDate
                              });

            ReportDGV.DataSource = reportData;

        }



        #endregion of Report Tab

        #region Delete Data

        // Delete Custommer
        private void FindCustDeleteBtn_Click(object sender, EventArgs e)
        {
            var personalNo = FindCustDeleteTB.Text;
            if (personalNo == "" || FindCustDeleteTB.Text.Length != 11)
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ მომხმარებლის პირადი ნომერი! \n" +
                    "რომელიც შედგება რიცხვებისაგან და მისი ზომა 11-ის ტოლია");
                return;
            }

            var thatCustommer = (from cust in context.Custommers
                                 where cust.PersonalNumber == personalNo
                                 select cust).FirstOrDefault();

            if (thatCustommer != null)
            {
                FindCustDataLbl.Text = $"{thatCustommer.Name} {thatCustommer.LastName}";
                infoTransferCustommerId = thatCustommer.Id;
            }
            else 
            {
                MessageBox.Show("ასეთი მომხმარებელი არ არსებობს!");
            }
        }


        private void DeleteCustBtn_Click(object sender, EventArgs e)
        {

            if (infoTransferCustommerId == 0)
            {
                MessageBox.Show("არავალიდური ინფორმაცია");
                return;
            }

            var custommer = (from cu in context.Custommers
                             where cu.Id == infoTransferCustommerId
                             select cu).FirstOrDefault();

            context.Custommers.DeleteOnSubmit(custommer);
            context.SubmitChanges();

            infoTransferCustommerId = 0;
            CustommersInCombo();
            GetCustommersData();
            GetReportData();
            MessageBox.Show("მომხმარებელი წარმატებით წაიშალა!");

        }

        private void ResetCustDataBtn_Click(object sender, EventArgs e)
        {
            FindCustDeleteTB.Clear();
            FindCustDataLbl.Text = "";
            infoTransferCustommerId = 0;
        }




        // Delete Genre

        private void ExistBtn_Click(object sender, EventArgs e)
        {
            var genreName = GenreTB.Text;
            if (genreName == "")
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ ჟანრის დასახელება");
                return;
            }

            var thatGenre = (from g in context.Genres
                             where g.Genre1.ToLower() == genreName.ToLower()
                             select g).FirstOrDefault();

            if (thatGenre != null)
            {
                label23.Text = $"Exist";
                infoTransferGenreId = thatGenre.Id;
            }
            else
            {
                MessageBox.Show("ასეთი ჟანრი არ არის ბაზაში!");
            }

        }

        private void GenreDeleteBtn_Click(object sender, EventArgs e)
        {
            if (infoTransferGenreId == 0)
            {
                MessageBox.Show("არავალიდური ინფორმაცია");
                return;
            }

            var genres = (from gg in context.Genres
                          where gg.Id == infoTransferGenreId
                          select gg).FirstOrDefault();

            context.Genres.DeleteOnSubmit(genres);
            context.SubmitChanges();

            infoTransferGenreId = 0;
            BooksData();
            GetGenres();
            AuthorsInCombo();
            CustommersInCombo();
            GetCustommersData();
            GetReportData();

            MessageBox.Show("ჟანრი წარმატებით წაიშალა!");
        }

        private void GenreResetBtn_Click(object sender, EventArgs e)
        {
            GenreTB.Clear();
            label23.Text = "";
            infoTransferGenreId = 0;
        }



        // Delete Author

        private void ExistAuthorBtn_Click(object sender, EventArgs e)
        {
            var authorName = AuthorDelTB.Text;
            if (authorName == "")
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ ავტორის სახელი");
                return;
            }

            var thatAuthor = (from au in context.Authors
                              where au.FullName.ToLower() == authorName.ToLower()
                              select au).FirstOrDefault();

            if (thatAuthor != null)
            {
                label26.Text = $"Exist";
                infoTransferAuthorId = thatAuthor.Id;
            }
            else
            {
                MessageBox.Show("ასეთი ავტორი არ არის ბაზაში!");
            }
        }


        private void DeleteAuthorBtn_Click(object sender, EventArgs e)
        {
            if (infoTransferAuthorId == 0)
            {
                MessageBox.Show("არავალიდური ინფორმაცია");
                return;
            }

            var author = (from auu in context.Authors
                          where auu.Id == infoTransferAuthorId
                          select auu).FirstOrDefault();

            context.Authors.DeleteOnSubmit(author);
            context.SubmitChanges();

            infoTransferAuthorId = 0;
            BooksData();
            GetGenres();
            AuthorsInCombo();
            CustommersInCombo();
            GetCustommersData();
            GetReportData();

            MessageBox.Show("ავტორი წარმატებით წაიშალა ბაზიდან");
        }

        private void ResetAuthorDataBtn_Click(object sender, EventArgs e)
        {
            AuthorDelTB.Clear();
            label26.Text = "";
            infoTransferAuthorId = 0;
        }


        // Delete Book 

        private void FindBookDeleteBtn_Click(object sender, EventArgs e)
        {
            var serialNo = BookDeleteTB.Text;
            if (serialNo == "" || serialNo.Length != 13)
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ წიგნის სერიული ნომერი \n" +
                    "გაითვალისწინეთ სერიული ნომერი შედგება 13 რიცხვისაგან");
                return;
            }

            var thatBook = (from bk in context.Books
                            where bk.SerialNumber == serialNo
                            select bk).FirstOrDefault();

            if (thatBook != null)
            {
                label29.Text = $"{thatBook.BookTitle}";
                infoTransferBookId = thatBook.Id;
            }
            else
            {
                MessageBox.Show("ასეთი წიგნი მსგავსი სერიული ნომრით არ არის ბაზაში!");
            }

        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {

            if (infoTransferBookId == 0)
            {
                MessageBox.Show("არავალიდური ინფორმაცია");
                return;
            }

            var book = (from b in context.Books
                        where b.Id == infoTransferBookId
                        select b).FirstOrDefault();

            if (!book.IsActive) 
            {
                MessageBox.Show("წიგნი ბაზიდან მას შემდეგ წაიშლება \n " +
                    "როცა დაბრუნდება ის ბიბლიოთეკაში!");
                return;
            }

            context.Books.DeleteOnSubmit(book);
            context.SubmitChanges();

            infoTransferBookId = 0;
            BooksData();
            GetGenres();
            AuthorsInCombo();
            CustommersInCombo();
            GetCustommersData();
            GetReportData();

            MessageBox.Show("წიგნი წარმატებით წაიშალა ბაზიდან");

        }


        private void ResetBookBTN_Click(object sender, EventArgs e)
        {
            BookDeleteTB.Clear();
            label29.Text = "";
            infoTransferBookId = 0;
        }

        #endregion of Delete Data


    }
}
