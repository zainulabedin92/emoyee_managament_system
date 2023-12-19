using Empoyee_Management_System.Database;
using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Models.Department;
using Empoyee_Management_System.Models.Designation;
using Empoyee_Management_System.Models.Employees;
using Empoyee_Management_System.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Empoyee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {

        private IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpPost]
        [Route("createDepartment")]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentModel createDepartmentModel)
        {
            try
            {
                var result = await _departmentService.CreateDepartment(createDepartmentModel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("getAllDepartments")]
        public async Task<IActionResult> GetAllDepartments()
        {
            try
            {
                var result = await _departmentService.GetAllDepartments();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("deleteDepartmentById")]
        public async Task<IActionResult> DeleteDepartmentById(long departmentId)
        {
            try
            {
                var result = await _departmentService.DeleteDepartmentById(departmentId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("getDepartmentById")]
        public async Task<IActionResult> getDepartmentById(long departmentId)
        {
            try
            {
                var result = await _departmentService.GetDepartmentById(departmentId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("updateDepartmentById")]
        public async Task<IActionResult> UpdateDepartmentById(long? departmentId, UpdateDepartmentModel updateDepartmentModel)
        {
            try
            {
                if (!departmentId.HasValue)
                {
                    throw new Exception("DepartmentId is Empty.");
                }
                var result = await _departmentService.UpdateDepartment(updateDepartmentModel, departmentId.Value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
