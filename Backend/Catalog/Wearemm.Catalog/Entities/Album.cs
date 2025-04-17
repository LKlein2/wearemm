namespace Wearemm.Catalog.Entities;

public class Album
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }

    public int ArtistId { get; set; }
    public Artist Artist { get; set; }

    public int GenreId { get; set; }
    public ICollection<Genre> Genres { get; set; }

    public int TrackId { get; set; }
    public ICollection<Track> Tracks { get; set; }

    public Album()
    {
        Genres = new List<Genre>();
        Tracks = new List<Track>();
    }
}
