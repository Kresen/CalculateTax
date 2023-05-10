using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Common.Enums
{
    public enum TaxType : byte
    {
        Progressive = 1,
        FlatValue = 2,
        FlatRate = 3
    }
}
