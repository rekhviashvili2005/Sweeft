using Microsoft.EntityFrameworkCore;
using Sweeft_5._0.Data;
using Sweeft_5._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_5._0.Services
{
    public class TeacherService
    {

        private readonly SchoolContext _context;

        public TeacherService(SchoolContext context)
        {
            _context = context;
        }

        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            var teachers = _context.TeacherStudents
                .Include(ts => ts.Teacher)
                .Include(ts => ts.Student)
                .Where(ts => ts.Student.FirstName == studentName)
                .Select(ts => ts.Teacher)
                .Distinct()
                .ToArray();

            return teachers;
        }

        public void PrintTeachersByStudent(string studentName)
        {
            var teachers = GetAllTeachersByStudent(studentName);

            if (teachers.Length == 0)
            {
                Console.WriteLine($"for student \"{studentName}\" teacher cannot be found");
                return;
            }

            Console.WriteLine($"teacher for student \"{studentName}\":");
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName} - subject: {t.Subject}");
            }
        }





















        //private readonly SchoolContext _context;

        //public TeacherService(SchoolContext context)
        //{
        //    _context = context;
        //}

        //public Teacher[] GetAllTeachersByStudent(string studentName)
        //{
        //    var teachers = _context.Teachers
        //        .Where(t => t.TeacherStudents
        //            .Any(ts => ts.Student.FirstName == studentName))
        //        .ToArray();

        //    return teachers;
        //}

        //public void PrintTeachersByStudent(string studentName)
        //{
        //    var teachers = GetAllTeachersByStudent(studentName);

        //    if (teachers.Length == 0)
        //    {
        //        Console.WriteLine($"for student \"{studentName}\" teacher cannot be found");
        //        return;
        //    }

        //    Console.WriteLine($"teacher for student \"{studentName}\":");
        //    foreach (var t in teachers)
        //    {
        //        Console.WriteLine($"{t.FirstName} {t.LastName} - subject: {t.Subject}");
        //    }
        //}

    }
}
