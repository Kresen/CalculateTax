using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TaxCalculator.UnitTests
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

        [Fact]
        public async Task Test_CalculateTax_Progressive()
        {
            // Arrange
            var taxBrackets = new List<TaxRates>()
        {
            new TaxRates { Rate = 10, From = 0, To = 8350 },
            new TaxRates { Rate = 15, From = 8351, To = 33950 },
            // Add more tax brackets as required
        };

            _taxCalculatorRepositoryMock.Setup(x => x.GetRates()).ReturnsAsync(taxBrackets);

            var input = new TaxCalculatorDTO
            {
                PostalCode = "1000",
                AnnualSalary = 50000
            };

            // Act
            var tax = await _service.CalculateTax(input);

            // Assert
            Assert.Equal(expectedTax, tax);  // replace expectedTax with the expected tax value for an annual salary of 50000
        }

        // Add more tests for other tax types (FlatValue and FlatRate) and edge cases
    }
}
