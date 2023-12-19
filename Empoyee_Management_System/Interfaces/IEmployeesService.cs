using Empoyee_Management_System.Database;
using Empoyee_Management_System.Models.Employees;

namespace Empoyee_Management_System.Interfaces
{
    public interface IEmployeeService
    {
        Task<bool> CreateEmployee(CreateEmployeeModel employeeModel);
        Task<List<AllEmployeesModel>> GetAllEmployees();
        Task<bool> DeleteEmployeeById(long employeeId);

        Task<AllEmployeesModel> GetEmployeeById(long employeeId);
        Task<bool> UpdateEmployee(UpdateEmployeeModel updatedEmployeeData, long employeeId);
    }
}
