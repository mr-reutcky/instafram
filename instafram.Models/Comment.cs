using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? PostId { get; set; }

    public int? UserId { get; set; }

    public string Comment1 { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
