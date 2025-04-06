﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VladimirKolchinKt_41_22.Models;

namespace VladimirKolchinKt_41_22.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        private const string TableName = "cd_discipline";

        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(p => p.DisciplineId)
                   .HasName($"pk_{TableName}_discipline_id");

            builder.Property(p => p.DisciplineId)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasColumnName("c_discipline_name")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200)
                   .HasComment("Название дисциплины");

            builder.HasMany(d => d.Workloads)
                   .WithOne(w => w.Discipline)
                   .HasForeignKey(w => w.DisciplineId)
                   .HasConstraintName($"fk_{TableName}_workload_id");
        }
    }
}
