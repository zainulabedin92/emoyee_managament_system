using Empoyee_Management_System.Controllers;
using Empoyee_Management_System.Database;
using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Models.Payrolls;

namespace Empoyee_Management_System.Services
{
    public class PayrollService : IPayrollService
    {
        private Employee_DbContext _context;

        public PayrollService(Employee_DbContext dbContext)
        {
            _context = dbContext               ;
        }

        public async Task<bool> CreatePayroll(CreatePayrollModel createPayrollModel)
        {
            Payroll @payroll = new Payroll()
            {
                EmployeeId = createPayrollModel.EmployeeId,
                BasicSalary = createPayrollModel.BasicSalary,
                Overtime = createPayrollModel.Overtime,
                Bonus = createPayrollModel.Bonus,
                Deduction = createPayrollModel.Deduction,
                Tax = createPayrollModel.Tax,
               // PayDate = createPayrollModel.PayDate,
                NetPay = createPayrollModel.NetPay,
                PaymentMethod = createPayrollModel.PaymentMethod
            };
            await _context.AddAsync(@payroll);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
