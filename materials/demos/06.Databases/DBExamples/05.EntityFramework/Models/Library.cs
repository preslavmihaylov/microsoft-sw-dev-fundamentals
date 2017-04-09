namespace _05.EntityFramework.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Library
    {
        private ICollection<Book> books;

        public Library()
        {
            this.books = new HashSet<Book>();
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}
