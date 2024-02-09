using FUM.BaseBusiness.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace General.Common
{
    public class GeneralDbContext : FUMBaseDBContext
    {
        public GeneralDbContext(IConfiguration configuration): base(configuration)
        {      
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<StudentCourse> StudentCourse { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Term>()
            .HasMany(e => e.Courses)
            .WithOne(e => e.Term)
            .HasForeignKey(e => e.TermRef)
            .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Lesson>()
            .HasMany(e => e.Courses)
            .WithOne(e => e.Lesson)
            .HasForeignKey(e => e.LessonRef)
            .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Student>()
            .HasMany(e => e.StudentCourses)
            .WithOne(e => e.Student)
            .HasForeignKey(e => e.StudentRef)
            .HasPrincipalKey(e => e.ID);

            modelBuilder.Entity<Course>()
           .HasMany(e => e.StudentCourses)
           .WithOne(e => e.Course)
           .HasForeignKey(e => e.CourseRef)
           .HasPrincipalKey(e => e.ID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = configuration.GetConnectionString("Postgres");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
