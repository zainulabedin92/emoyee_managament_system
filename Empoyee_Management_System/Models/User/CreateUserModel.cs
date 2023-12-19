namespace Empoyee_Management_System.Models.User
{
    public class CreateUserModel
    {
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;
        public int EmployeeId { get; set; } = 0;

    }
}
