using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoDLC.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    [Required(ErrorMessage ="Username is required")]
    public string Username { get; set; } = null!;

	[Required(ErrorMessage = "Password is required")]
	public string Password { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public DateOnly? Birthday { get; set; }

    public byte? Gender { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage ="Invalid email")]
    public string Email { get; set; } = null!;

    public string? Phonenumber { get; set; }

    public string? Address { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
