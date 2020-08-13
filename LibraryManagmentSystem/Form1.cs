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
        private int infoTransferBookId; // ***
        private int infoTransferBorrowId; //**
        private readonly LibraryDataContext context;
        public Form1()
        {
            context = new LibraryDataContext();
            InitializeComponent();
            BooksData();
            //GetGenres();
            AuthorsInCombo();
            CustommersInCombo();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            var authorId = (int)AuthorCombo.SelectedValue;

            // fill Books ComboBox
            BooksInCombo(authorId);
        }

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
            var custId = (from cust in context.Custommers
                          where cust.PersonalNumber == custPersonalNo
                          select new {
                                cust.Id,
                                FullName = $"{cust.Name} {cust.LastName}"
                          }).FirstOrDefault();



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
                CustomerId = custId.Id,
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
            MessageBox.Show($"წიგნი გაიტანა {custId.FullName}");
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
                join author in context.Authors on book.Author equals author.Id
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
            if (serialNo == null) 
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ წიგნის სერიული ნომერი!");
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
            ReturnBookSNTB.Clear();
            ReturnBookNameLbl.ResetText();

        }


        #region Helper Functions For Borrow Book Tab

        private void AuthorsInCombo() 
        {
            var authors = (from a in context.Authors
                           select a);

            AuthorCombo.DisplayMember = "FullName";
            AuthorCombo.ValueMember = "Id";
            AuthorCombo.DataSource = authors;
        }

        private void BooksInCombo(int authorId)
        {
            var books = (from bk in context.Books
                         where bk.Author == authorId && bk.IsActive == true
                         select bk);

            BooksCombo.DisplayMember = "BookTitle";
            BooksCombo.ValueMember = "SerialNumber";
            BooksCombo.DataSource = books;
        }

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
        #endregion of Helper Functions


        #endregion of Borrow Book Tab





        #region Registration Tab
        //private void GetGenres()
        //{
        //    var genres = (from g in context.Genres
        //                  select g);

        //    //GenreLB.DisplayMember = "Genre1";
        //    //GenreLB.ValueMember = "Id";
        //    //GenreLB.DataSource = genres;

        //    foreach (var item in genres)
        //    {
        //        GenreLB.Items.Add(item.Genre1);
        //    }
        //}
        private void AddCustommerBtn_Click(object sender, EventArgs e)
        {
            ////აქ CustommerVM მაგივრად შემეძლო შემოტანილი მნიშვნელობები პირდაპირ Custommer
            //// ცხრილში ჩამეწერა მარა მერე შეზღუდვებს ვეღა დავადებდი და ასე გავაკეთე  ---
            //var custommer = new CustommerVM
            //{
            //    Name = NameTB.Text,
            //    LastName = LastNameTB.Text,
            //    Birthday = BirthdayDatePicker.Value,
            //    Email = EmailTB.Text,
            //    Address = AddressTB.Text,
            //    PersonalNumber = PersonalNoTB.Text
            //};

            //var ifExist = (from cust in context.Custommers
            //               where cust.PersonalNumber == custommer.PersonalNumber
            //               select cust).FirstOrDefault();

            //if (ifExist == null)
            //{
            //    var cust = new Custommer
            //    {
            //        Name = custommer.Name,
            //        LastName = custommer.LastName,
            //        BirthDay = custommer.Birthday,
            //        Email = custommer.Email,
            //        Address = custommer.Address,
            //        PersonalNumber = custommer.PersonalNumber
            //    };
            //    context.Custommers.InsertOnSubmit(cust);
            //}
            //else
            //{
            //    MessageBox.Show("ასეთი მომხმარებელი უკვე რეგისტრირებულია");
            //}

            //context.SubmitChanges();

            //NameTB.Clear();
            //LastNameTB.Clear();
            //EmailTB.Clear();
            //AddressTB.Clear();
            //PersonalNoTB.Clear();

            //MessageBox.Show("მომხმარებელი დაემატა წარმატებით");
        }
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            //var genres = new List<string>();

            //foreach (var item in GenreLB.SelectedItems)
            //{
            //    genres.Add(item.ToString());
            //}

            //var book = new BookVM
            //{
            //    BookTitle = BookTitleTB.Text,
            //    Author = AuthorTB.Text,
            //    PublishDate = PublishDatePicker.Value,
            //    SerialNumber = SerialNoTB.Text,
            //    Genres = genres
            //};

            //var ifExist = (from bk in context.Books
            //               where bk.SerialNumber == book.SerialNumber
            //               select bk).FirstOrDefault();

            //if (ifExist == null)
            //{
            //    var bk = new Book
            //    {
            //        BookTitle = book.BookTitle,
            //        Author = book.Author,
            //        PublicationDate = book.PublishDate,
            //        SerialNumber = book.SerialNumber
            //    };

            //    context.Books.InsertOnSubmit(bk);
            //    context.SubmitChanges();

            //    // adding data in GenresOfBooks

            //    var bookId = (from id in context.Books
            //                  where id.SerialNumber == book.SerialNumber
            //                  select id.Id).FirstOrDefault();

            //    var genreIds = new List<int>();

            //    foreach (var item in book.Genres)
            //    {
            //        var Ids = (from gid in context.Genres
            //                   where gid.Genre1 == item
            //                   select gid.Id).FirstOrDefault();
            //        genreIds.Add(Ids);
            //    }


            //    foreach (var item in genreIds)
            //    {
            //        var bookGenres = new GenresOfBook
            //        {
            //            BookId = bookId,
            //            GenreId = item
            //        };
            //        context.GenresOfBooks.InsertOnSubmit(bookGenres);
            //    }
            //    context.SubmitChanges();


            //    BookTitleTB.Clear();
            //    AuthorTB.Clear();
            //    GenreLB.ClearSelected();
            //    SerialNoTB.Clear();

            //    MessageBox.Show("წიგნი დაემატა წარმატებით");
            //}
            //else
            //{
            //    MessageBox.Show("ასეთი წიგნი უკვე რეგისტრირებულია");
            //}
        }

        #endregion

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            BarCode serial = new BarCode();
            byte[] barcodeInBytes = serial.generateBarcodeToByteArray();
        }

        
    }
}
