namespace MoviePortal.Models;

public class MovieDetails : Movie
{
    public string Overview { get; set; } = string.Empty;
    public string ReleaseDate { get; set; } = string.Empty;
    public Credits Credits { get; set; } = new();
}