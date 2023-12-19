using System;
using System.Collections.Generic;

namespace Empoyee_Management_System.Database;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Address { get; set; }

    public string JoiningDate { get; set; } = null!;

    public long? DepartmentId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }
}
