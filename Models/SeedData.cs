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
                        BPrice = 9.95,
                        BPageNumber = 1488
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
                        BPrice = 14.58,
                        BPageNumber = 944
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
                        BPrice = 21.54,
                        BPageNumber = 832
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
                        BPrice = 11.61,
                        BPageNumber = 864
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
                        BPrice = 13.33,
                        BPageNumber = 528
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
                        BPrice = 15.95,
                        BPageNumber = 288
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
                        BPrice = 14.99,
                        BPageNumber = 304
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
                        BPrice = 21.66,
                        BPageNumber = 240
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
                        BPrice = 29.16,
                        BPageNumber = 400
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
                        BPrice = 15.03,
                        BPageNumber = 642
                    },

                    new Libro
                    {
                        ISBN = "978-0765360960",
                        BTitle = "Mistborn",
                        BAuthorFirst = "Brandon",
                        BAuthorMid = null,
                        BAuthorLast = "Sanderson",
                        BPublisher = "Tor Books",
                        BClassification = "Fiction",
                        BCategory = "Fantasy",
                        BPrice = 20.00,
                        BPageNumber = 672
                    },

                    new Libro
                    {
                        ISBN = "978-1250768681",
                        BTitle = "The Eye of the World",
                        BAuthorFirst = "Robert",
                        BAuthorMid = null,
                        BAuthorLast = "Jordan",
                        BPublisher = "Doherty Associates, LLC, Tom",
                        BClassification = "Fiction",
                        BCategory = "Fantasy",
                        BPrice = 25.00,
                        BPageNumber = 784
                    },

                    new Libro
                    {
                        ISBN = "978-0802726438",
                        BTitle = "This Is My God",
                        BAuthorFirst = "Herman",
                        BAuthorMid = null,
                        BAuthorLast = "Wouk",
                        BPublisher = "Doubleday",
                        BClassification = "Non-Fiction",
                        BCategory = "Religion",
                        BPrice = 15.00,
                        BPageNumber = 368
                    }
                );
                //this piece of code saves the list above to the database
                context.SaveChanges();
            }
        }
    }
}
