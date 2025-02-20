using System;
using System.Collections.Generic;

namespace instafram.Models;

public partial class Dm
{
    public int Dmid { get; set; }

    public int? SenderId { get; set; }

    public int? RecipientId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public virtual User? Recipient { get; set; }

    public virtual User? Sender { get; set; }
}
