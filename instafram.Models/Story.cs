namespace instafram.Models;

public partial class Story
{
    public int StoryId { get; set; }

    public int? Views { get; set; }

    public int? Likes { get; set; }

    public int? UserId { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? ExpirationTime { get; set; }

    public virtual User? User { get; set; }
}
