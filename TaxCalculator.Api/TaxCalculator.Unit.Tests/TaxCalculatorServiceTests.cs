using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Dtos;
using TaxCalculator.Repository.Interfaces;
using TaxCalculator.Services;

namespace TaxCalculator.Unit.Tests
{
    public class TaxCalculatorServiceTests
    {
        private Mock<ITaxCalculatorRepository> _taxCalculatorRepositoryMock;
        private TaxCalculatorService _service;

        public TaxCalculatorServiceTests()
        {
            _taxCalculatorRepositoryMock = new Mock<ITaxCalculatorRepository>();
            _service = new TaxCalculatorService(_taxCalculatorRepositoryMock.Object);
        }

        [Test]
        public async Task Test_CalculateTax_Progressive()
        {
            var taxBrackets = new List<TaxRates>()
        {
            new TaxRates { Rate = 10, From = 0, To = 8350 },
            new TaxRates { Rate = 15, From = 8351, To = 33950 },
        };

            _taxCalculatorRepositoryMock.Setup(x => x.GetRates()).ReturnsAsync(taxBrackets);

            var input = new TaxCalculatorDTO
            {
                PostalCode = "1000",
                AnnualSalary = 50000
            };


            var tax = await _service.CalculateTax(input);


            Assert.AreEqual(4675.1, tax);  
        }

     
    }
}
