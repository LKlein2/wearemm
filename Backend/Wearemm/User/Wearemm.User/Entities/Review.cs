namespace Wearemm.User.Entities;

public class Review
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int AlbumId { get; set; }
    public int Rating { get; set; } // Rating out of 5
    public string Comment { get; set; }
    public DateTime ReviewDate { get; set; }
}
