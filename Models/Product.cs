using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string ManufacturerId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string? Photo { get; set; }

    public string? Details { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
