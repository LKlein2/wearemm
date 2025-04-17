namespace Wearemm.Catalog.Entities;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public ICollection<Album> Albums { get; set; }
    public ICollection<Genre> Genres { get; set; }

    public Artist()
    {
        Albums = new List<Album>();
        Genres = new List<Genre>();
    }
}
