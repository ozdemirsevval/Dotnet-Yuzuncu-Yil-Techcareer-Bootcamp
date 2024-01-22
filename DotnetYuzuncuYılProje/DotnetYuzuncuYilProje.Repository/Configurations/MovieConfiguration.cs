using DotnetYuzuncuYilProje.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Repository.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id); //primary key
            
            builder.Property(m => m.Id).UseIdentityColumn(); //id otomatik olarak 1'er 1'er artsın

            //Film ismi için 100 karakter sınırlaması ve isim girişini zorunlu yapsın
            builder.Property(m => m.MovieTitle).HasMaxLength(100).IsRequired();
            builder.Property(m => m.MovieReleasedDate).IsRequired();
        }
    }
}
