using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class Storylike
{
    public int StoryLikeId { get; set; }

    public int? UserId { get; set; }

    public int? StoryId { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual Story? Story { get; set; }

    public virtual User? User { get; set; }
}
