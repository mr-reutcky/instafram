using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string? Bio { get; set; }

    public string Username { get; set; } = null!;

    public string? ProfilePic { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Dm> DmRecipients { get; set; } = new List<Dm>();

    public virtual ICollection<Dm> DmSenders { get; set; } = new List<Dm>();

    public virtual ICollection<Follow> FollowFollowees { get; set; } = new List<Follow>();

    public virtual ICollection<Follow> FollowFollowers { get; set; } = new List<Follow>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Story> Stories { get; set; } = new List<Story>();

    public virtual ICollection<Storylike> Storylikes { get; set; } = new List<Storylike>();
}
