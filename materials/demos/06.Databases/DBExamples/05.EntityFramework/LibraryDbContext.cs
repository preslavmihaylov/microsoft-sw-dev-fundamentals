namespace _05.EntityFramework
{
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Migrations;
    using Models;

    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            : base("LibraryDbContext")
        {
            var migration = new MigrateDatabaseToLatestVersion<LibraryDbContext, Configuration>();
            Database.SetInitializer(migration);
        }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Library> Libraries { get; set; }


    }

}