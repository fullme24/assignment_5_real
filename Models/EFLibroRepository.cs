using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models
{
    //This is the class that inherets from the ILibroRepository
    //and is the file that we call to migrate our updated database structor
    public class EFLibroRepository : ILibroRepository
    {
        private LibrosDbContext _context;

        //contructor
        public EFLibroRepository (LibrosDbContext context)
        {
            _context = context;
        }
        public IQueryable<Libro> Libros => _context.Libros;
    }
}
