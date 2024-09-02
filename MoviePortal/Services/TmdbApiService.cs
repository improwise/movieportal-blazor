using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using MoviePortal.Models;

namespace MoviePortal.Services;

public class TmdbApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public TmdbApiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["TMDB_API_KEY"] ?? throw new InvalidOperationException("TMDB API key not found.");
        if (string.IsNullOrWhiteSpace(_apiKey) || _apiKey == "TMDB_API_KEY_PLACEHOLDER")
        {
            throw new InvalidOperationException("TMDB API key is not set correctly.");
        }

        _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
    }

    public async Task<MovieSearchResponse> SearchMoviesAsync(string query, int page = 1)
    {
        return await _httpClient.GetFromJsonAsync<MovieSearchResponse>(
                   $"search/movie?api_key={_apiKey}&query={Uri.EscapeDataString(query)}&page={page}")
               ?? throw new HttpRequestException("Failed to fetch search results.");
    }

    public async Task<MovieSearchResponse> GetPopularMoviesAsync(int page = 1)
    {
        return await _httpClient.GetFromJsonAsync<MovieSearchResponse>($"movie/popular?api_key={_apiKey}&page={page}")
               ?? throw new HttpRequestException("Failed to fetch popular movies.");
    }

    public async Task<MovieDetails> GetMovieDetailsAsync(int movieId)
    {
        return await _httpClient.GetFromJsonAsync<MovieDetails>(
                   $"movie/{movieId}?api_key={_apiKey}&append_to_response=credits")
               ?? throw new HttpRequestException("Failed to fetch movie details.");
    }
}