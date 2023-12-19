using Empoyee_Management_System.Database;
using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Models.Department;
using Empoyee_Management_System.Models.Designation;
using Empoyee_Management_System.Models.Employees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Empoyee_Management_System.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly Employee_DbContext _context;

        public DepartmentService(Employee_DbContext dbcontext)
        {
            _context = dbcontext;
        }
        public async Task<bool> CreateDepartment(CreateDepartmentModel departmentModel)
        {

            Department @department = new Department()
            {
                DepartmentName = departmentModel.DepartmentName,
                Description = departmentModel.Description,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            await _context.Departments.AddAsync(@department);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<AllDepartmentsModel>> GetAllDepartments()
        {
            var departments = await (from department in _context.Departments
                                   select new AllDepartmentsModel
                                   {
                                       DepartmentId = department.DepartmentId,
                                       DepartmentName = department.DepartmentName,
                                       Description = department.Description,
                                   }).ToListAsync();
            return departments;
        }

        public async Task<bool> DeleteDepartmentById(long departmentId)
        {
            var department = await _context.Departments.FindAsync(departmentId);

            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<AllDepartmentsModel> GetDepartmentById(long departmentId)
        {
            var departmentDetails = await (from department in _context.Departments
                                   where department.DepartmentId == departmentId
                                   select new AllDepartmentsModel
                                   {
                                       DepartmentId = department.DepartmentId,
                                       DepartmentName = department.DepartmentName,
                                       Description = department.Description
                                   }).FirstOrDefaultAsync();
            return departmentDetails;
        }

        public async Task<bool> UpdateDepartment(UpdateDepartmentModel updatedDepartmentData, long departmentId)
        {
            var department = await _context.Departments.FindAsync(departmentId);

            if (department == null)
            {
                return false; // Employee with the given ID was not found.
            }

            department.DepartmentName = updatedDepartmentData.DepartmentName;
            department.Description = updatedDepartmentData.Description;
            department.DateModified = DateTime.Now;

            // Save the changes to the database.
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
