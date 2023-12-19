namespace Empoyee_Management_System.Models.Department
{
    public class UpdateDepartmentModel
    {
        public long? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public string? Description { get; set; }

        public DateTime DateModified { get; set; }
    }
}
