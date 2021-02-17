using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//This file is made to start our database off with some information. 
namespace assignment_5_real.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            LibrosDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<LibrosDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            if (!context.Libros.Any())
            {
                context.Libros.AddRange(
                    new Libro
                    {
                        ISBN = "978-0451419439",
                        BTitle = "Les Miserables",
                        BAuthorFirst = "Victor",
                        BAuthorMid = null,
                        BAuthorLast = "Hugo",
                        BPublisher = "Signet",
                        BClassification = "Fiction",
                        BCategory = "Classic",
                        BPrice = 9.95
                    },
                    new Libro
                    {
                        ISBN = "978-0743270755",
                        BTitle = "Team of Rivals",
                        BAuthorFirst = "Doris",
                        BAuthorMid = "Kearns",
                        BAuthorLast = "Goodwin",
                        BPublisher = "Simon & Schuster",
                        BClassification = "Non-Fiction",
                        BCategory = "Biography",
                        BPrice = 14.58
                    },
                    new Libro
                    {
                        ISBN = "978-0553384611",
                        BTitle = "The Snowball",
                        BAuthorFirst = "Alice",
                        BAuthorMid = null,
                        BAuthorLast = "Schroeder",
                        BPublisher = "Bantam",
                        BClassification = "Non-Fiction",
                        BCategory = "Biography",
                        BPrice = 21.54
                    },
                    new Libro
                    {
                        ISBN = "978-0812981254",
                        BTitle = "American Ulysses",
                        BAuthorFirst = "Ronald",
                        BAuthorMid = "C.",
                        BAuthorLast = "White",
                        BPublisher = "Random House",
                        BClassification = "Non-Fiction",
                        BCategory = "Biography",
                        BPrice = 11.61
                    },
                    new Libro
                    {
                        ISBN = "978-0812974492",
                        BTitle = "Unbroken",
                        BAuthorFirst = "Laura",
                        BAuthorMid = null,
                        BAuthorLast = "Hillenbrand",
                        BPublisher = "Random House",
                        BClassification = "Non-Fiction",
                        BCategory = "Historical",
                        BPrice = 13.33
                    },
                    new Libro
                    {
                        ISBN = "978-0804171281",
                        BTitle = "The Great Train Robbery",
                        BAuthorFirst = "Michael",
                        BAuthorMid = null,
                        BAuthorLast = "Crichton",
                        BPublisher = "Vintage",
                        BClassification = "Fiction",
                        BCategory = "Historical Fiction",
                        BPrice = 15.95
                    },
                    new Libro
                    {
                        ISBN = "978-1455586691",
                        BTitle = "Deep Work",
                        BAuthorFirst = "Cal",
                        BAuthorMid = null,
                        BAuthorLast = "Newport",
                        BPublisher = "Grand Central Publishing",
                        BClassification = "Non-Fiction",
                        BCategory = "Self-Help",
                        BPrice = 14.99
                    },
                    new Libro
                    {
                        ISBN = "978-0812974492",
                        BTitle = "It's Your Ship",
                        BAuthorFirst = "Michael",
                        BAuthorMid = null,
                        BAuthorLast = "Abrashoff",
                        BPublisher = "Grand Central Publishing",
                        BClassification = "Non-Fiction",
                        BCategory = "Self-Help",
                        BPrice = 21.66
                    },
                    new Libro
                    {
                        ISBN = "978-1591847984",
                        BTitle = "The Virgin Way",
                        BAuthorFirst = "Richard",
                        BAuthorMid = null,
                        BAuthorLast = "Branson",
                        BPublisher = "Portfolio",
                        BClassification = "Non-Fiction",
                        BCategory = "Business",
                        BPrice = 29.16
                    },
                    new Libro
                    {
                        ISBN = "978-0553393613",
                        BTitle = "Sycamore Row",
                        BAuthorFirst = "John",
                        BAuthorMid = null,
                        BAuthorLast = "Grisham",
                        BPublisher = "Bantam",
                        BClassification = "Fiction",
                        BCategory = "Thrillers",
                        BPrice = 15.03
                    }
                );
                //this piece of code saves the list above to the database
                context.SaveChanges();
            }
        }
    }
}
