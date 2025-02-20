using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class Post
{
    public int PostId { get; set; }

    public DateTime? Timestamp { get; set; }

    public int? Views { get; set; }

    public int? Likes { get; set; }

    public int? UserId { get; set; }

    public string? Caption { get; set; }

    public string? Picture { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Like> LikesNavigation { get; set; } = new List<Like>();

    public virtual User? User { get; set; }
}
