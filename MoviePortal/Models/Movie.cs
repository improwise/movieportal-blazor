using System.Text.Json.Serialization;

namespace MoviePortal.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("poster_path")] public string? PosterPath { get; set; }

    [JsonPropertyName("genre_ids")] public List<int> GenreIds { get; set; } = new();
}