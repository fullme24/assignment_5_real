using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage {get; set;}
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((double)TotalNumItems / ItemsPerPage));
    }
}
