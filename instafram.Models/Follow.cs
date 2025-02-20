using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class Follow
{
    public int FollowId { get; set; }

    public int? FollowerId { get; set; }

    public int? FolloweeId { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual User? Followee { get; set; }

    public virtual User? Follower { get; set; }
}
