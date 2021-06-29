using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookAPI_YT.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) // Main Contrusctor
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }

        public DbSet<AmlAlerts> AmlAlerts { get; set; }
    }
}
