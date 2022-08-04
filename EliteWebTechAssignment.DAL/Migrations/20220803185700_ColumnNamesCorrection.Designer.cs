﻿// <auto-generated />
using EliteWebTechAssignment.DAL;
using EliteWebTechAssignment.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EliteWebTechAssignment.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220803185700_ColumnNamesCorrection")]
    partial class ColumnNamesCorrection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EliteWebTechAssignment.Domain.Models.ProgrammeEntityModel", b =>
                {
                    b.Property<int>("programmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProgrammeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("programmeName")
                        .IsRequired()
                        .HasColumnName("ProgrammeName");

                    b.HasKey("programmeId");

                    b.ToTable("Programmes");
                });

            modelBuilder.Entity("EliteWebTechAssignment.Domain.Models.StudentEntityModel", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("studentName")
                        .IsRequired()
                        .HasColumnName("StudentName");

                    b.HasKey("studentId");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
