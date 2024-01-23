using DotnetYuzuncuYilProje.Core;
using DotnetYuzuncuYilProje.Core.Repositeries;
using DotnetYuzuncuYilProje.Core.Services;
using DotnetYuzuncuYilProje.Repository.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Service.Services
{
    public class TicketService : Service<Ticket>, ITicketService
    {
        public TicketService(IGenericRepository<Ticket> repository, UnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
