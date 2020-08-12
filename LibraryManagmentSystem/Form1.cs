﻿using LibraryManagmentSystem.Models;
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

namespace LibraryManagmentSystem
{
    public partial class Form1 : Form
    {
        private readonly LibraryDataContext context;
        public Form1()
        {
            context = new LibraryDataContext();
            InitializeComponent();
            BooksData();
            GetGenres();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Books List Tab
        private void BooksData()
        {
            var Books = (
                from book in context.Books
                orderby book.BookTitle ascending
                select new
                {
                    book.BookTitle,
                    book.Author
                }).AsQueryable();

            //var Books = context.Books.AsQueryable();



            BooksDataGridView.DataSource = Books;
        }
        #endregion

        #region Registration Tab
        private void GetGenres()
        {
            var genres = (from g in context.Genres
                          select g);
            foreach (var item in genres)
            {
                GenreLB.Items.Add(item.Genre1);
                //GenreLB.ValueMember = item.Id.;
            }
        }
        private void AddCustommerBtn_Click(object sender, EventArgs e)
        {
            //აქ CustommerVM მაგივრად შემეძლო შემოტანილი მნიშვნელობები პირდაპირ Custommer
            // ცხრილში ჩამეწერა მარა მერე შეზღუდვებს ვეღა დავადებდი და ასე გავაკეთე  ---
            var custommer = new CustommerVM
            {
                Name = NameTB.Text,
                LastName = LastNameTB.Text,
                Birthday = BirthdayDatePicker.Value,
                Email = EmailTB.Text,
                Address = AddressTB.Text,
                PersonalNumber = PersonalNoTB.Text
            };

            var ifExist = (from cust in context.Custommers
                           where cust.PersonalNumber == custommer.PersonalNumber
                           select cust).FirstOrDefault();

            if (ifExist == null)
            {
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
            }
            else 
            {
                MessageBox.Show("ასეთი მომხმარებელი უკვე რეგისტრირებულია");
            }

            context.SubmitChanges();

            NameTB.Clear();
            LastNameTB.Clear();
            EmailTB.Clear();
            AddressTB.Clear();
            PersonalNoTB.Clear();

            MessageBox.Show("მომხმარებელი დაემატა წარმატებით");
        }
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            var genres = new List<string>();

            foreach (var item in GenreLB.SelectedItems)
            {
                genres.Add(item.ToString());
            }

            var book = new BookVM
            {
                BookTitle = BookTitleTB.Text,
                Author = AuthorTB.Text,
                PublishDate = PublishDatePicker.Value,
                SerialNumber = SerialNoTB.Text,
                Genres = genres
            };

            var ifExist = (from bk in context.Books
                           where bk.SerialNumber == book.SerialNumber
                           select bk).FirstOrDefault();

            if (ifExist == null)
            {
                var bk = new Book
                {
                    BookTitle = book.BookTitle,
                    Author = book.Author,
                    PublicationDate = book.PublishDate,
                    SerialNumber = book.SerialNumber
                };

                context.Books.InsertOnSubmit(bk);
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
                AuthorTB.Clear();
                GenreLB.ClearSelected();
                SerialNoTB.Clear();

                MessageBox.Show("წიგნი დაემატა წარმატებით");
            }
            else 
            {
                MessageBox.Show("ასეთი წიგნი უკვე რეგისტრირებულია");
            }
        }
        #endregion





    }
}