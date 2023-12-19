﻿namespace Empoyee_Management_System.Models.Employees
{
    public class CreateEmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string JoiningDate { get; set; }
        public long? DepartmentId { get; set; }
    }
}
