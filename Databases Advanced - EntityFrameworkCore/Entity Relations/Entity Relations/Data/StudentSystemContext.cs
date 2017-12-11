using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Homework> HomeworkSubmissions { get; set; }


        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            :base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<StudentCourse> (entity =>
            {
                entity.HasKey(sc => (new { sc.CourseId, sc.StudentId }));

                builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.CourseEnrollments)
                .HasForeignKey(sc => sc.StudentId);

                builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(s => s.StudentsEnrolled)
                .HasForeignKey(sc => sc.CourseId);
            });

            builder.Entity<Student>(entity =>
            {
                entity.HasMany(s => s.HomeworkSubmissions)
                .WithOne(h => h.Student)
                .HasForeignKey(h => h.StudentId);

                entity.Property(s => s.Name)
                .HasMaxLength(100);

                entity.Property(s => s.PhoneNumber)
                .IsUnicode(false)
                .IsRequired(false)
                .HasColumnType("CHAR(10)");

                entity.Property(s => s.PhoneNumber)
                .IsRequired(false);
            });

            builder.Entity<Course>(entity =>
            {
                entity.HasMany(c => c.Resources)
                .WithOne(r => r.Course)
                .HasForeignKey(r => r.CourseId);

                entity.HasMany(c => c.HomeworkSubmissions)
                .WithOne(h => h.Course)
                .HasForeignKey(h => h.CourseId);

                entity.Property(c => c.Name)
                .HasMaxLength(80);

                entity.Property(c => c.Description)
                .IsRequired(false);
            });

            builder.Entity<Resource>(entity =>
            {
                entity.Property(r => r.Name)
                .HasMaxLength(50);

                entity.Property(r => r.Url)
                .IsUnicode(false);
            });

            builder.Entity<Homework>(entity =>
            {
                entity.HasKey(hs => hs.HomeworkId);

                entity.Property(h => h.Content)
                .IsUnicode(false);
            });
        }
    }
}
