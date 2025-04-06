using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VladimirKolchinKt_41_22.Models;

namespace VladimirKolchinKt_41_22.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        private const string TableName = "cd_department";

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(p => p.DepartmentId)
                   .HasName($"pk_{TableName}_department_id");

            builder.Property(p => p.DepartmentId)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasColumnName("c_department_name")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.HasOne(d => d.HeadTeacher)
                   .WithOne()
                   .HasForeignKey<Department>(d => d.HeadTeacherId)
                   .HasConstraintName($"fk_{TableName}_head_teacher_id")
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
