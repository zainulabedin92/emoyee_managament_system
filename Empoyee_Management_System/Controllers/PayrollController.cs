using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Models.Payrolls;
using Empoyee_Management_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Empoyee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollController : Controller
    {
        private  IPayrollService _payrollService;
    public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpPost]
        [Route("createPayroll")]
        public async Task<IActionResult> CreatePayroll([FromBody] CreatePayrollModel createPayrollModel)
        {
            try
            {
                var _result = await _payrollService.CreatePayroll(createPayrollModel);
                return Ok(_result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
