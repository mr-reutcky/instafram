using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class Story
{
    public int StoryId { get; set; }

    public int? Views { get; set; }

    public int? UserId { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? ExpirationTime { get; set; }

    public int LikeStory { get; set; }
    public virtual ICollection<Storylike> Storylikes { get; set; } = new List<Storylike>();

    public virtual User? User { get; set; }
}