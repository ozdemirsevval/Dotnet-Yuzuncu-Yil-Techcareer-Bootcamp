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
    public class AudienceSeed : IEntityTypeConfiguration<Audience>
    {
        public void Configure(EntityTypeBuilder<Audience> builder)
        {
            builder.HasData(
                new Audience { Id = 1, FirstName = "Şevval", LastName = "Özdemir", Age = 21,
                              MovieId = 1, Email = "sevvalozdemir.tech@gmail.com" },
                new Audience { Id = 2, FirstName = "Beyza", LastName = "Kuru", Age = 23,
                             MovieId = 4, Email = "beyzakuru@gmail.com" }
                );
        }
    }
}
