using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readBooks
{
    internal class Book{
        public int BookId { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublicationYear { get; set; }

        public bool IsInStock { get; set; }

        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}