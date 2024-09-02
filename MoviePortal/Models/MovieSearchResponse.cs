namespace MoviePortal.Models;

public class MovieSearchResponse
{
    public List<Movie> Results { get; set; } = new();
    public int Page { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}