
using Microsoft.EntityFrameworkCore;
using Sweeft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft.Data
{
    // 777 დავალებაა და რაღაცა არ გამოდის 
    public class SchoolContext : DbContext
    {
        
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(
                 @"Server=DESKTOP-HH0EHH1\\SQLEXPRESS;Database=mydb;Trusted_Connection=True;Persist Security Info=True;Encrypt=False;MultipleActiveResultSets=true;");
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Students)
                .WithMany(s => s.Teachers)
                .UsingEntity(j => j.ToTable("TeacherStudents"));
                //.HasKey("TeacherID", "PupilID");
        }
    }
}