using pickmeamovieAPI.Services;
using System.Net.Http.Headers;

public class MovieDbService : IMovieDbService
{
    private readonly HttpClient _httpClient;

    public MovieDbService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", "apikey");
    }

    public async Task<string> TestAuthenticationAsync()
    {
        var response = await _httpClient.GetAsync("authentication");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
    public async Task<string> GetPopularMovies()
    {
        var response = await _httpClient.GetAsync("movie/popular?language=en-US&page=1");
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetMovieByID( int id)
    {
        var response = await _httpClient.GetAsync("movie/popular?language=en-US&page=1");

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();

    }
}