using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VladimirKolchinKt_41_22.Models;

namespace VladimirKolchinKt_41_22.Configurations
{
    public class WorkloadConfiguration : IEntityTypeConfiguration<WorkLoad>
    {
        private const string TableName = "cd_workload";

        public void Configure(EntityTypeBuilder<WorkLoad> builder)
        {
            builder.HasKey(p => p.WorkloadId)
                   .HasName($"pk_{TableName}_workload_id");

            builder.Property(p => p.WorkloadId)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Hours)
                   .IsRequired()
                   .HasColumnName("c_workload_hours")
                   .HasColumnType("int")
                   .HasComment("Количество часов нагрузки");

            builder.HasOne(w => w.Discipline)
                   .WithMany(d => d.Workloads)
                   .HasForeignKey(w => w.DisciplineId)
                   .HasConstraintName($"fk_{TableName}_discipline_id");

            builder.HasOne(w => w.Teacher)
                   .WithMany(t => t.Workloads)
                   .HasForeignKey(w => w.TeacherId)
                   .HasConstraintName($"fk_{TableName}_teacher_id");
        }
    }
}
