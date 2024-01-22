using DotnetYuzuncuYilProje.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Repository.Seeds
{
    public class MovieSeed : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie { Id = 1, MovieTitle = "Before Sunrise", 
                           CreatedDateTime = DateTime.Now, MovieType= "Romance"  },
                new Movie { Id = 2, MovieTitle = "Before Sunset", 
                           CreatedDateTime = DateTime.Now, MovieType = "Romance" },
                new Movie { Id = 3, MovieTitle = "Before Midnight",
                            CreatedDateTime = DateTime.Now ,MovieType = "Romance" },
                new Movie { Id = 4, MovieTitle = "Inception", 
                            CreatedDateTime =DateTime.Now, MovieType = "Science-Fiction" }
                );
        }
    }
}
