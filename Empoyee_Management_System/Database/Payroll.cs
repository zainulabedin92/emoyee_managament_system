using System;
using System.Collections.Generic;

namespace Empoyee_Management_System.Database;

public partial class Payroll
{
    public long PayrollId { get; set; }

    public long EmployeeId { get; set; }

    public long? BasicSalary { get; set; }

    public long? Overtime { get; set; }

    public long? Bonus { get; set; }

    public long? Deduction { get; set; }

    public decimal? Tax { get; set; }

    public DateTime? PayDate { get; set; }

    public string? NetPay { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
}
