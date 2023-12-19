using System;
using System.Collections.Generic;

namespace Empoyee_Management_System.Database;

public partial class Attendance
{
    public long AttendanceId { get; set; }

    public long EmployeeId { get; set; }

    public DateTime AttendanceDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }
}
