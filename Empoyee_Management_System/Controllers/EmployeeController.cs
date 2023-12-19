using Empoyee_Management_System.Database;
using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Models.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Empoyee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost]
        [Route("createEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeModel createEmployeeModel)
        {
            try
            {
                var result = await _employeeService.CreateEmployee(createEmployeeModel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("getAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var result = await _employeeService.GetAllEmployees();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("deleteEmployeeById")]
        public async Task<IActionResult> DeleteEmployeeById(long employeeId)
        {
            try
            {
                var result = await _employeeService.DeleteEmployeeById(employeeId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("getEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(long employeeId)
        {
            try
            {
                var result = await _employeeService.GetEmployeeById(employeeId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("updateEmployeeById")]
        public async Task<IActionResult> UpdateEmployeeById(long? employeeId, UpdateEmployeeModel updateEmployeeModel)
        {
            try
            {
                if (!employeeId.HasValue)
                {
                    throw new Exception("EmployeeId is Empty.");
                }
                var result = await _employeeService.UpdateEmployee(updateEmployeeModel, employeeId.Value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
