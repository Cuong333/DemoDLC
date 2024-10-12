using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public DateOnly? Birthday { get; set; }

    public byte? Gender { get; set; }

    public string Email { get; set; } = null!;

    public string? Phonenumber { get; set; }

    public string? Address { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
