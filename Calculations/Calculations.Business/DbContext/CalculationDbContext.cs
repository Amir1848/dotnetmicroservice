using Calculations.Common;
using FUM.BaseBusiness.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business.DbContext
{
    public class CalculationsDbContext : FUMBaseDBContext
    {
        public DbSet<Fee> Fees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=FumCalculations;Username=postgres;Password=1");
        }
    }
}
