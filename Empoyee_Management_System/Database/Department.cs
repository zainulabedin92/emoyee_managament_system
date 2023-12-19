using System;
using System.Collections.Generic;

namespace Empoyee_Management_System.Database;

public partial class Department
{
    public long DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? Description { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }
}
