using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Models
{
    public class BookVM
    {
        private string bookTitle;
        [DisplayName("Book Title")]
        public string BookTitle 
        {
            get { return bookTitle; }

            set 
            {
                if (value == null)
                    MessageBox.Show("შეავსეთ Book Title ველი");
                bookTitle = value;
            }
        }
        public int Author { get; set; }
        public DateTime PublishDate { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public bool IsActive { get; set; }
        public string SerialNumber { get; set; }

    }
}
