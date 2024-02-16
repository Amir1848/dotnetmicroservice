using Calculations.Common;
using FUM.BaseBusiness.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business.DbContext
{
    public class CalculationsDbContext : FUMBaseDBContext
    {
        public CalculationsDbContext(IConfiguration configuration) : base(configuration)
        {
        }
        public DbSet<Fee> Fees { get; set; }
    }
}
