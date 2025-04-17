namespace Wearemm.User.Entities;

public class Playlist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<int> Tracks { get; set; }

    public Playlist() => Tracks = [];
}
