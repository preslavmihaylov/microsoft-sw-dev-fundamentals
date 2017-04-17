namespace _05.EntityFramework.Models
{
    using System.Collections.Generic;

    public class Author
    {
        private ICollection<Book> books;
        public Author()
        {
            this.books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual  ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}