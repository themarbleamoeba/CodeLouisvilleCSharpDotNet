using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CodeLouisvilleProject.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "Payback",
                    ReleaseDate = DateTime.Parse("1999-2-5"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 4.99M
                },

                 new Movie
                 {
                     Title = "Ghostbusters",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "PG-13",
                     Price = 8.99M
                 },

                  new Movie
                  {
                      Title = "Ghostbusters 2",
                      ReleaseDate = DateTime.Parse("1986-2-23"),
                      Genre = "Comedy",
                      Rating = "PG-13",
                      Price = 7.99M
                  },

                  new Movie
                  {
                      Title = "No Country For Old Men",
                      ReleaseDate = DateTime.Parse("2007-11-2"),
                      Genre = "Thriller",
                      Rating = "R",
                      Price = 10.99M
                  },

                  new Movie
                  {
                      Title = "The Sound of Music",
                      ReleaseDate = DateTime.Parse("1965-3-29"),
                      Genre = "Musical",
                      Rating = "G",
                      Price = 3.99M
                  }
                );
            context.SaveChanges();
        }
    }
}
