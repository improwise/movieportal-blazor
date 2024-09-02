namespace MoviePortal.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string PosterPath { get; set; } = string.Empty;
    public List<int> GenreIds { get; set; } = new();
}