using Microsoft.EntityFrameworkCore;
using Sweeft_5._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_5._0.Data
{
    public class SchoolContext : DbContext

    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Student>()
                .HasKey(s => s.PupilID);

            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.TeacherID);

           
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<TeacherStudent>().ToTable("TeacherStudents");

            
            modelBuilder.Entity<TeacherStudent>()
                .HasKey(ts => new { ts.TeacherID, ts.PupilID });

            modelBuilder.Entity<TeacherStudent>()
                .HasOne(ts => ts.Teacher)
                .WithMany(t => t.TeacherStudents)
                .HasForeignKey(ts => ts.TeacherID);

            modelBuilder.Entity<TeacherStudent>()
                .HasOne(ts => ts.Student)
                .WithMany(s => s.TeacherStudents)
                .HasForeignKey(ts => ts.PupilID);
        }
    }
}
