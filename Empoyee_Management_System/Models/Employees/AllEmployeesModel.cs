namespace Empoyee_Management_System.Models.Employees
{
    public class AllEmployeesModel
    {
        public long EmployeeId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string DateOfBirth { get; set; } = null!;

        public string? Gender { get; set; }

        public string? PhoneNumber { get; set; }

        public string Email { get; set; } = null!;

        public string? Address { get; set; }

        public string JoiningDate { get; set; } = null!;

        public long? DepartmentId { get; set; }


        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
