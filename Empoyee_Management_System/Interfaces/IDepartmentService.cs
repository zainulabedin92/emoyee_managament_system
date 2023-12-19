using Empoyee_Management_System.Models.Department;
using Empoyee_Management_System.Models.Designation;
using Empoyee_Management_System.Models.Employees;
using Microsoft.AspNetCore.Mvc;

namespace Empoyee_Management_System.Interfaces
{
    public interface IDepartmentService
    {
        Task<bool> CreateDepartment(CreateDepartmentModel createDepartmentModel);
        Task<List<AllDepartmentsModel>> GetAllDepartments();
        Task<AllDepartmentsModel> GetDepartmentById(long departmentId);
        Task<bool> UpdateDepartment(UpdateDepartmentModel updateDepartmentModel, long departmentId);
        Task<bool> DeleteDepartmentById(long departmentId);
    }
}
