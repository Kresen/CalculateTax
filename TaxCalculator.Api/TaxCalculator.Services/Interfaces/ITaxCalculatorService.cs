using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Dtos;

namespace TaxCalculator.Services.Interfaces
{
    public interface ITaxCalculatorService
    {
        Task<decimal> CalculateTax(TaxCalculatorDTO input);
    }
}
