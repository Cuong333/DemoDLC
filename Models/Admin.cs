using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public DateOnly Birthday { get; set; }

    public byte Gender { get; set; }

    public int RoleId { get; set; }

    public string Phonenumber { get; set; } = null!;

    public string? Address { get; set; }

    public string? Photo { get; set; }

    public string Email { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
