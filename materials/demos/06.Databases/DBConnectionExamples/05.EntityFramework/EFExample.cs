using _05.EntityFramework;
using _05.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class EFExample
{
    static void Main()
    {
        var context = new LibraryDbContext();

        //Create Authors of the books

        var firstAuthor = new Author
        {
            FirstName = "Gosho",
            LastName = "Petkov",
            Books = new HashSet<Book>()
        };
        var secondAuthor = new Author
        {
            FirstName = "Minka",
            LastName = "Todorova",
            Books = new HashSet<Book>()
        };

        // Add authors to database
        context.Authors.Add(firstAuthor);
        context.Authors.Add(secondAuthor);

        context.SaveChanges();

        //Create Books

        var firstBook = new Book
        {
            Title = "Pesho's Book",
            Author = context.Authors.FirstOrDefault(a => a.FirstName == "Gosho"),
            Description = "Mnogo Interesna Kniga",
            Price = 25
        };

        var secondBook = new Book
        {
            Title = "Gosho's Book",
            Author = context.Authors.FirstOrDefault(a => a.FirstName == "Minka"),
            Description = "Mnogo Tapa Kniga",
            Price = 1
        };
        
        context.Books.Add(firstBook);
        context.Books.Add(secondBook);
        context.SaveChanges();

        //Create Libraries

        var library = new Library
        {
            Name = "Biblioteka",
            Books = new HashSet<Book>() { firstBook, secondBook }
        };
        context.Libraries.Add(library);
        context.SaveChanges();
    }
}