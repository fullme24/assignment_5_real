using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models
{
    //This is the linch pin class. This will help us actually use the database and
    //it's information
    public class LibrosDbContext : DbContext
    {
        public LibrosDbContext(DbContextOptions<LibrosDbContext> options) : base (options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
    }
}
