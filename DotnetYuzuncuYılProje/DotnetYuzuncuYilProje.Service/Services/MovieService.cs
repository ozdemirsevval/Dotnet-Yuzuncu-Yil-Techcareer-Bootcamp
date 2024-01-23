using DotnetYuzuncuYilProje.Core;
using DotnetYuzuncuYilProje.Core.Services;
using DotnetYuzuncuYilProje.Repository.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Service.Services
{
    public class MovieService : Service<Movie>, IMovieService
    {
        public MovieService(Core.Repositeries.IGenericRepository<Movie> repository, UnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
