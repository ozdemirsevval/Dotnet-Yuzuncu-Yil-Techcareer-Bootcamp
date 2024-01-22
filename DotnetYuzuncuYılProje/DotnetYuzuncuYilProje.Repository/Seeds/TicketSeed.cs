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
    public class TicketSeed : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasData(
                new Ticket { Id = 1, AudienceId = 1, CreatedDateTime = DateTime.Now, Price = 100 },
                new Ticket { Id = 2, AudienceId = 2, CreatedDateTime = DateTime.Now, Price = 120 }
                );
        }
    }
}
