namespace Empoyee_Management_System.Models.Payrolls
{
    public class CreatePayrollModel
    {
        public long EmployeeId { get; set; }

        public long? BasicSalary { get; set; }

        public long? Overtime { get; set; }

        public long? Bonus { get; set; }

        public long? Deduction { get; set; }

        public decimal? Tax { get; set; }

        public DateTime? PayDate { get; set; }

        public string? NetPay { get; set; }

        public string? PaymentMethod { get; set; }
    }
}
