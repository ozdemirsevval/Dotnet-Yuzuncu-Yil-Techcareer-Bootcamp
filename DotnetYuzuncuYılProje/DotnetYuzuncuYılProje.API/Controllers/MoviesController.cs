using AutoMapper;
using DotnetYuzuncuYilProje.Core.DTOs;
using DotnetYuzuncuYilProje.Core.Services;
using DotnetYuzuncuYilProje.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilProje.API.Controllers
{

    public class MoviesController : CustomBaseController
    {
        private IMapper _mapper;

        private readonly IMovieService _movieService;

        public MoviesController(IMapper mapper, IMovieService movieService)
        {
            _mapper = mapper;
            _movieService = movieService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var movies = await _movieService.GetAllAsync();
            var moviesDto = _mapper.Map<List<MovieDto>>(movies.ToList());
            return CreateActionResult(GlobalResultDto<List<MovieDto>>.Success(200, moviesDto));
        }
    }
}
