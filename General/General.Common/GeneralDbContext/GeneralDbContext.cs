using FUM.BaseBusiness.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace General.Common
{
    public class GeneralDbContext : FUMBaseDBContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Term> Terms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=FumGeneral;Username=postgres;Password=1");
        }
    }
}
