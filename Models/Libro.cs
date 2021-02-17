using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5_real.Models
{
    public class Libro
    {
        [Key]
        public int BookID { get; set; }
        //In the description of the assignemnt, 
        //there was no mention of a form to add 
        //information to the data base. So I didnt 
        //make one. However, I have made a regex for ISBN.
        //I texted it online and it works. However, you, 
        //the TA, will not be able to test it here on my website.
        //Here is one sample website to test regexs: http://regexstorm.net/
        [Required]
        [RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "Please enter a valid ISNB number")]
        public string ISBN { get; set; }
        [Required]
        public string BTitle { get; set; }
        [Required]
        public string BAuthorFirst { get; set; }
        /*I want it noted that this field I made and not all authors have a middle name listed so I had to make the field nullable*/
        public string? BAuthorMid { get; set; }
        [Required]
        public string BAuthorLast { get; set; }
        [Required]
        public string BPublisher { get; set; }
        [Required]
        public string BClassification { get; set; }
        public string BCategory { get; set; }
        [Required]
        public double BPrice { get; set; }
    }
}
