using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Manufacturer
{
    public string ManufacturerId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Descriptions { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
