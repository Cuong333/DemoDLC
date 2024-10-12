using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string PaymentType { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
