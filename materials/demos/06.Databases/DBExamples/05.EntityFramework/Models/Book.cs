namespace _05.EntityFramework.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Key]
        public int Id { get; set; }

        public int AuthorId { get; set; }
        
        public virtual Author Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public virtual Library Library { get; set; }
    }
}
