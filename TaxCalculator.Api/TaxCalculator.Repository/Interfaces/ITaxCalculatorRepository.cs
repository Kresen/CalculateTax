using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Common.Enums;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Repository.Interfaces
{
    public interface ITaxCalculatorRepository
    {
        Task<List<TaxRates>> GetRates();
        Task<bool> SaveSalaryTax(SalaryTax salaryTax);
    }
}
