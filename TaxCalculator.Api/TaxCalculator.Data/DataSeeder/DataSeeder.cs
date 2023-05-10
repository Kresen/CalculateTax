using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Data.DataSeeder
{
    public static class DataSeeder
    {
        public static void SeedTaxRates(this ModelBuilder modelBuilder)
        {
            List<TaxRates> list = new List<TaxRates>(){ new TaxRates
            {
                Id = Guid.NewGuid(),
                Rate = 10,
                From = 0,
                To = 8350
            },
            new TaxRates{
                Id = Guid.NewGuid(),
                Rate = 15,
                From = 8351,
                To = 33950

            },
            new TaxRates{
                Id = Guid.NewGuid(),
                Rate = 25,
                From = 33951,
                To = 82250

            },
                new TaxRates{
                Id = Guid.NewGuid(),
                Rate = 28,
                From = 82251,
                To = 171550

            },
                new TaxRates{
                Id = Guid.NewGuid(),
                Rate = 33,
                From = 171551,
                To = 372950

            },
              new TaxRates{
                Id = Guid.NewGuid(),
                Rate = 35,
                From = 372951,
                To = long.MaxValue
            }
        };

            modelBuilder.Entity<TaxRates>().HasData(list);
        }
    }
}
