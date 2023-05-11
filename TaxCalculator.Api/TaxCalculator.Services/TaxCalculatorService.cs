using TaxCalculator.Common.Enums;
using TaxCalculator.Dtos;
using TaxCalculator.Repository.Interfaces;
using TaxCalculator.Services.Interfaces;

namespace TaxCalculator.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private readonly ITaxCalculatorRepository _taxCalculatorRepository;
        public TaxCalculatorService(ITaxCalculatorRepository taxCalculatorRepository) {
            _taxCalculatorRepository = taxCalculatorRepository;
        }


        public async Task<decimal> CalculateTax(TaxCalculatorDTO input)
        {
            var taxType = GetType(input.PostalCode);
            decimal taxAmount = 0;

            switch (taxType)
            {
                case TaxType.FlatValue:
                    if (input.AnnualSalary < 200000)
                        taxAmount = (input.AnnualSalary * 0.05M);
                    else
                        taxAmount = 10000;                        
                            break;
                case TaxType.FlatRate:
                    taxAmount = (input.AnnualSalary * 0.175M);
                    break;
                case TaxType.Progressive:
                    taxAmount = await CalcualteProgressiveTax(input.AnnualSalary);
                    break;

            }

           await  _taxCalculatorRepository.SaveSalaryTax(new Domain.Entities.SalaryTax
            {
                Id = Guid.NewGuid(),
                AnnualSalary = input.AnnualSalary,
                PostalCode = input.PostalCode,
                CreatedDate = DateTime.UtcNow,
                TaxAmount = taxAmount
            });

            return taxAmount;
        }

        private TaxType GetType (string postalCode)
        {
            if (postalCode.Trim().ToUpper().Contains("A"))
                return TaxType.FlatValue;
            else if (postalCode.Trim().Equals("7000"))
                return TaxType.FlatRate;
            else
                return TaxType.Progressive;

        }

        private async Task<decimal> CalcualteProgressiveTax(long annualSalary)
        {
            var taxBrackets = await _taxCalculatorRepository.GetRates();
            decimal tax = 0;

            foreach (var bracket in taxBrackets)
            {
               
                    if (annualSalary > bracket.To)
                    {
                        tax += (bracket.To - bracket.From + 1) * (bracket.Rate / 100);
                    }
                    else if (annualSalary > bracket.From)
                    {
                        tax += (annualSalary - bracket.From + 1) * (bracket.Rate / 100);
                        break;
                    }
            }

            return tax;
        }
    }
}
