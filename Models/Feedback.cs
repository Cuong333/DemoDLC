using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public int CustomerId { get; set; }

    public string ProductId { get; set; } = null!;

    public string? Rating { get; set; }

    public string? Comment { get; set; }

    public string? IsStatus { get; set; }

    public virtual Product Product { get; set; } = null!;
}
