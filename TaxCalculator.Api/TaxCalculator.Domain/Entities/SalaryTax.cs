using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Domain.Entities
{
    public class SalaryTax
    {
        [Key]
        public Guid Id { get; set; }

        public string PostalCode { get; set; }

        public long AnnualSalary { get; set; }

        public decimal TaxAmount { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
