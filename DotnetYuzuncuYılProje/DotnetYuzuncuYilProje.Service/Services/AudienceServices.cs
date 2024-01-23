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
    public class AudienceServices : Service<Audience>, IAudienceService
    {
        public AudienceServices(IGenericRepository<Audience> repository, UnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
