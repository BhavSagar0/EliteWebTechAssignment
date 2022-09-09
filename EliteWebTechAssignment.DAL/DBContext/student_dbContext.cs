using System;
using EliteWebTechAssignment.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EliteWebTechAssignment.DAL.DBContext
{
    public partial class student_dbContext : DbContext
    {
        public student_dbContext()
        {
        }

        public student_dbContext(DbContextOptions<student_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CurrentSem> CurrentSem { get; set; }
        public virtual DbSet<IntakeYear> IntakeYear { get; set; }
        public virtual DbSet<Programmes> Programmes { get; set; }
        public virtual DbSet<StudentMarks> StudentMarks { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User=root;Password=Pragatia27$;Database=student_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrentSem>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("current_sem");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.CurrentSem1).HasColumnName("current_sem");

                entity.Property(e => e.StudentId)
                    .HasColumnName("student_id")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<IntakeYear>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("intake_year");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.IntakeYear1).HasColumnName("intake_year");

                entity.Property(e => e.StudentId)
                    .HasColumnName("student_id")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<Programmes>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("programmes");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.ProgrammeName)
                    .HasColumnName("programme_name")
                    .HasColumnType("char(50)");
            });

            modelBuilder.Entity<StudentMarks>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("student_marks");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.Marks1).HasColumnName("marks1");

                entity.Property(e => e.Marks2).HasColumnName("marks2");

                entity.Property(e => e.Marks3).HasColumnName("marks3");

                entity.Property(e => e.StudentId).HasColumnName("student_id");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("students");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.CollegeName)
                    .HasColumnName("college_name")
                    .HasColumnType("char(50)");

                entity.Property(e => e.ProgrammeId).HasColumnName("programme_id");

                entity.Property(e => e.StudentName)
                    .HasColumnName("student_name")
                    .HasColumnType("char(40)");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("subjects");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.ProgrammeId).HasColumnName("programme_id");

                entity.Property(e => e.SubjectName)
                    .HasColumnName("subject_name")
                    .HasColumnType("char(30)");
            });
        }
    }
}
