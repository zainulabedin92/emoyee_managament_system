namespace Empoyee_Management_System.Models.Employees
{
    public class AllDepartmentsModel
    {
        public long DepartmentId { get; set; }

        public string? DepartmentName { get; set; }

        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
