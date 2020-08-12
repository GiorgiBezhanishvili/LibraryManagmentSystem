using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    public class BookVM
    {
        [DisplayName("Book Title")]
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public bool IsActive { get; set; }
        public string SerialNumber { get; set; }

    }
}
