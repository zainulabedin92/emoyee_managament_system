using System;
using System.Collections.Generic;

namespace Empoyee_Management_System.Database;

public partial class EmployeeRole
{
    public long RoleId { get; set; }

    public string? RoleName { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }
}
