using VladimirKolchinKt_41_22.Configurations;
using VladimirKolchinKt_41_22.Models;
using Microsoft.EntityFrameworkCore;

namespace VladimirKolchinKt_41_22.Database
{
    public class TeacherDbContext : DbContext
    {
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Discipline> Disciplines { get; set; }
        DbSet<AcademicDegree> AcademicDegrees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<WorkLoad> Workloads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicDegreeConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new WorkloadConfiguration());
        }

        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options)
        {
        }
    }
}
