﻿using VladimirKolchinKt_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VladimirKolchinKt_41_22.Configurations
{
    public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
    {
        private const string TableName = "cd_academic_degree";

        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            builder.HasKey(p => p.AcademicDegreeId)
                   .HasName($"pk_{TableName}_academic_degree_id");

            builder.Property(p => p.AcademicDegreeId)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasColumnName("c_academic_degree_name")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200)
                   .HasComment("Название ученой степени");

            builder.HasMany(ad => ad.Teachers)
                   .WithOne(t => t.AcademicDegree)
                   .HasForeignKey(t => t.AcademicDegreeId)
                   .HasConstraintName($"fk_{TableName}_teacher_id");
        }
    }
}
