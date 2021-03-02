using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Libro> Libros { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
