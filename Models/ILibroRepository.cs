using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models
{
    //this exists to be inhereted later on as the basic mold
    public interface ILibroRepository
    {
        IQueryable<Libro> Libros { get; }
    }
}
