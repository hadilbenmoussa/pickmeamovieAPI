namespace pickmeamovieAPI.Services
{
    public interface IMovieDbService
    {
        Task<string> TestAuthenticationAsync();
        Task<string> GetPopularMovies();
        Task<string> GetMovieByID(int id);


        // Add other API methods here
    }
}
