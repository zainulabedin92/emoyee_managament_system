using Empoyee_Management_System.Models.Payrolls;

namespace Empoyee_Management_System.Interfaces
{
    public interface IPayrollService
    {
        Task<bool> CreatePayroll(CreatePayrollModel createPayrollModel);
    }
}
