using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pickmeamovieAPI.Services;

namespace pickmeamovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieDbService _movieDbService;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(IMovieDbService movieDbService, ILogger<MoviesController> logger)
        {
            _movieDbService = movieDbService;
            _logger = logger;
        }

        [HttpGet(Name = "GetPopularMovies")]
        public async Task<IActionResult> GetPopularMovies()
        {
            return Ok(await _movieDbService.GetPopularMovies());
            // Use the service here
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieByID(int id)
        {
            return Ok(await _movieDbService.GetMovieByID(id));



        }
    }
}
