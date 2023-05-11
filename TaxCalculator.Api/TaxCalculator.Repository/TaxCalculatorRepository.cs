using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Common.Enums;
using TaxCalculator.Data.Contexts;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Repository.Interfaces;

namespace TaxCalculator.Repository
{
    public class TaxCalculatorRepository : ITaxCalculatorRepository
    {
        private readonly TaxCalcContext _context;

        public TaxCalculatorRepository(TaxCalcContext context)
        {
            _context = context;
        }

        public async Task<List<TaxRates>> GetRates()
        {
            return await _context.TaxRates.ToListAsync();
        }

        public async Task<bool> SaveSalaryTax(SalaryTax salaryTax)
        {
            _context.SalaryTax.Add(salaryTax);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
