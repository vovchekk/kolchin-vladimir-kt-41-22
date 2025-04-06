﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VladimirKolchinKt_41_22.Database;

#nullable disable

namespace VladimirKolchinKt_41_22.Migrations
{
    [DbContext(typeof(TeacherDbContext))]
    [Migration("20250406221208_name")]
    partial class name
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.AcademicDegree", b =>
                {
                    b.Property<int>("AcademicDegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcademicDegreeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_academic_degree_name")
                        .HasComment("Название ученой степени");

                    b.HasKey("AcademicDegreeId")
                        .HasName("pk_cd_academic_degree_academic_degree_id");

                    b.ToTable("AcademicDegrees");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("HeadTeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("HeadTeacherId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplineId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_discipline_name")
                        .HasComment("Название дисциплины");

                    b.HasKey("DisciplineId")
                        .HasName("pk_cd_discipline_discipline_id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_post_name")
                        .HasComment("Название должности");

                    b.HasKey("PostId")
                        .HasName("pk_cd_post_post_id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<int>("AcademicDegreeId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_teacher_firstname");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_teacher_lastname");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_teacher_middlename");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.HasIndex("AcademicDegreeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PostId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.WorkLoad", b =>
                {
                    b.Property<int>("WorkloadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkloadId"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int")
                        .HasColumnName("c_workload_hours")
                        .HasComment("Количество часов нагрузки");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("WorkloadId")
                        .HasName("pk_cd_workload_workload_id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Workloads");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Department", b =>
                {
                    b.HasOne("VladimirKolchinKt_41_22.Models.Teacher", "HeadTeacher")
                        .WithOne()
                        .HasForeignKey("VladimirKolchinKt_41_22.Models.Department", "HeadTeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("HeadTeacher");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Teacher", b =>
                {
                    b.HasOne("VladimirKolchinKt_41_22.Models.AcademicDegree", "AcademicDegree")
                        .WithMany("Teachers")
                        .HasForeignKey("AcademicDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_academic_degree_teacher_id");

                    b.HasOne("VladimirKolchinKt_41_22.Models.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("fk_cd_teacher_department_id");

                    b.HasOne("VladimirKolchinKt_41_22.Models.Post", "Post")
                        .WithMany("Teachers")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_post_teacher_id");

                    b.Navigation("AcademicDegree");

                    b.Navigation("Department");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.WorkLoad", b =>
                {
                    b.HasOne("VladimirKolchinKt_41_22.Models.Discipline", "Discipline")
                        .WithMany("Workloads")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_workload_discipline_id");

                    b.HasOne("VladimirKolchinKt_41_22.Models.Teacher", "Teacher")
                        .WithMany("Workloads")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cd_workload_teacher_id");

                    b.Navigation("Discipline");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.AcademicDegree", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Discipline", b =>
                {
                    b.Navigation("Workloads");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Post", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("VladimirKolchinKt_41_22.Models.Teacher", b =>
                {
                    b.Navigation("Workloads");
                });
#pragma warning restore 612, 618
        }
    }
}
