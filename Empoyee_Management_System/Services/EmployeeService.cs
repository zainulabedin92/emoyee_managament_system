using Empoyee_Management_System.Database;
using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Models.Employees;
using Microsoft.EntityFrameworkCore;

namespace Empoyee_Management_System.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly Employee_DbContext _context;

        public EmployeeService(Employee_DbContext dbcontext)
        {
            _context = dbcontext;
        }
        public async Task<bool>  CreateEmployee(CreateEmployeeModel employeeModel)
        {

            Employee @employee = new Employee()
            {
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                Gender = employeeModel.Gender,
                PhoneNumber = employeeModel.PhoneNumber,
                Email = employeeModel.Email,
                Address = employeeModel.Address,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                DateOfBirth = employeeModel.DateOfBirth,
                JoiningDate = employeeModel.JoiningDate,
                DepartmentId = employeeModel.DepartmentId
            };
            await _context.Employees.AddAsync(@employee);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<AllEmployeesModel>> GetAllEmployees()
        {
            var employees = await (from employee in _context.Employees
                                   select new AllEmployeesModel
                                   {
                                       EmployeeId=employee.EmployeeId,
                                       FirstName=employee.FirstName,
                                       LastName = employee.LastName,
                                       Address = employee.Address,
                                       DateOfBirth = employee.DateOfBirth,
                                       Gender = employee.Gender,
                                       JoiningDate =employee.JoiningDate,
                                       Email = employee.Email,
                                       PhoneNumber = employee.PhoneNumber,
                                       DepartmentId = employee.DepartmentId
                                   }).ToListAsync();
            return employees;
        }

        public async Task<bool> DeleteEmployeeById(long employeeId)
        {
            var employee = await _context.Employees.FindAsync(employeeId);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return true;
            }

            return false; // Employee with the given ID was not found.
        }

        public async Task<AllEmployeesModel> GetEmployeeById(long employeeId)
        {
            var employees = await (from employee in _context.Employees where employee.EmployeeId == employeeId
                                   select new AllEmployeesModel
                                   {
                                       EmployeeId = employee.EmployeeId,
                                       FirstName = employee.FirstName,
                                       LastName = employee.LastName,
                                       Address = employee.Address,
                                       DateOfBirth = employee.DateOfBirth,
                                       Gender = employee.Gender,
                                       JoiningDate = employee.JoiningDate,
                                       Email = employee.Email,
                                       PhoneNumber = employee.PhoneNumber,
                                       DepartmentId = employee.DepartmentId
                                   }).FirstOrDefaultAsync();
            return employees;
        }

        public async Task<bool> UpdateEmployee(UpdateEmployeeModel updatedEmployeeData,long employeeId )
        {
            var employee = await _context.Employees.FindAsync(employeeId);

            if (employee == null)
            {
                return false; // Employee with the given ID was not found.
            }

            // Update the employee properties with the new values.
            employee.FirstName = updatedEmployeeData.FirstName;
            employee.LastName = updatedEmployeeData.LastName;
            employee.Gender = updatedEmployeeData.Gender;
            employee.PhoneNumber = updatedEmployeeData.PhoneNumber;
            employee.Email = updatedEmployeeData.Email;
            employee.Address = updatedEmployeeData.Address;
            employee.DateModified = DateTime.Now;
            employee.DateOfBirth = updatedEmployeeData.DateOfBirth;
            employee.JoiningDate = updatedEmployeeData.JoiningDate;
            employee.DepartmentId = updatedEmployeeData.DepartmentId;

            // Save the changes to the database.
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
