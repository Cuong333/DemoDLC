using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public string TotalPrice { get; set; } = null!;

    public byte OrderStatus { get; set; }

    public int PaymentMethodId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual OrderDetail? OrderDetail { get; set; }

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
