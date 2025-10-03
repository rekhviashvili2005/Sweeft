using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sweeft_5._0.Data;
using Sweeft_5._0.Services;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {



        //------------------

        // IConfiguration - წამოვიღოთ appsettings.json
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();



        // DbContext Options - SQL Server კავშირის დამატება
        var options = new DbContextOptionsBuilder<SchoolContext>()
            .UseSqlServer(config.GetConnectionString("SchoolDB"))
            .Options;

        // DbContext შექმნა
        using var context = new SchoolContext(options);

        // TeacherService შექმნა
        var service = new TeacherService(context);

        // Console input
        Console.Write("enter student name: ");
        string studentName = Console.ReadLine().Trim();

        // მასწავლებლების ბეჭდვა
        service.PrintTeachersByStudent(studentName);

        //Console.WriteLine("დასასრულს დაწერეთ ნებისმიერი კლავიატურა გასასვლელად...");
        Console.ReadKey();
    }
}