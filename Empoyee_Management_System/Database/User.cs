using System;
using System.Collections.Generic;

namespace Empoyee_Management_System.Database;

public partial class User
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long? EmployeeId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }
}
