using System;
using System.Collections.Generic;

namespace DemoDLC.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();
}
