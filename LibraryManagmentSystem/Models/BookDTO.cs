using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    public class BookDTO
    {
        public int Id { get; set; }

        [DisplayName("Book Title")]
        public string BookTitle { get; set; }

        public string Author { get; set; }

        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }

        [DisplayName("Publication Date")]
        public DateTime PublicationDate { get; set; }

        public string Genres { get; set; }

        [DisplayName("Avaliable")]
        public bool IsActive { get; set; }
    }
}
