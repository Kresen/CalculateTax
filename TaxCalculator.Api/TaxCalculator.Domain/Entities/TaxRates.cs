using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Domain.Entities
{
    public class TaxRates
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Rate { get; set; }

        public long From { get; set; }

        public long To { get; set; }
    }
}
