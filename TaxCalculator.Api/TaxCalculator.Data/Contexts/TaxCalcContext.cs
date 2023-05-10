using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Data.DataSeeder;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Data.Contexts
{
    public class TaxCalcContext : DbContext
    {
        public TaxCalcContext(DbContextOptions<TaxCalcContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedTaxRates();
        }

        public DbSet<TaxRates> TaxRates { get; set; }
    }
}
