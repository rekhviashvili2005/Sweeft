using Sweeft;
using Sweeft._9_davaleba;
using Sweeft.Services;

internal class Program
{
    private static async Task Main(string[] args)
    {


        // -------- 999  ----------// 
        SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        BinaryPrinter binaryPrinter = new BinaryPrinter(semaphore);
        MessageDisplay messageDisplay = new MessageDisplay(semaphore);

        Task task1 = binaryPrinter.PrintBinaryNumbers();
        Task task2 = messageDisplay.ShowPeriodicMessage();

        await Task.WhenAll(task1, task2);


        //-------------------------------------------//





        // -------------------- 88888  ar gamovida--------------//
        // Console.WriteLine("all files are creating...............\n");

        //await CountryDataGenerator.GenerateCountryDataFiles();

        //------------------------------------//






        // ----------- 7777 არ გამოვიდა  ----------------//

        //var service = new StudentService(); 
        //string Name = "ლუკა";

        //var teachers = service.GetAllTeachersByStudent(Name);
        //if (teachers.Length == 0)
        //{
        //    Console.WriteLine("Cannot find");
        //}
        //else
        //{

        //    foreach (var teacher in teachers)
        //    {
        //        Console.WriteLine($"- {teacher.FirstName} {teacher.LastName} (study: {teacher.Subject})");
        //    }
        //}

        // ----------------------------------------------------------- //










        // -----  ####1111 palindromi  ------  //
        //Console.Write("Enter text: ");
        //string txt = Console.ReadLine().Trim();
        //bool result = Palindrome.sPalindrome(txt);
        //Console.WriteLine(result);

        //    // ----------------------------------- //


        //    // --- ###222 ხურდების მინიმალური რაოდენობა ----- //
        //Console.Write("Enter the amount in tetri: ");
        //int money = int.Parse(Console.ReadLine());
        //int result = Coins.MinSplit(money);

        //Console.WriteLine($"Minimum number of coins needed: {result}");
        //    //   ---------------------------------------------   //



        // ------ ### 333 array ში მინიმალურზე ----- // 
        //int[] masivi = { 5, 4, 6, 0, 1, 3, 8, 9, 10 };
        //int shedegi = MinArrays.NotContains(masivi);
        //Console.WriteLine(shedegi);
        // ----------------------------------------- //



        // ------ ### 4444  ----- //

        //Console.WriteLine("enter the text: ");
        //string txt = Console.ReadLine();
        //bool frchxilebis_datvla = Brackets.IsProperly(txt);
        //Console.WriteLine(frchxilebis_datvla);

        // ----------------------------------------- //


        // ------ ### 5555  ----- //

        //Console.Write("Enter the number of floors: ");
        //int n = int.Parse(Console.ReadLine());
        //int result = Stairs.CountVariants(n);
        //Console.WriteLine($"{n} floor: {result} Option");




        //}
    }
}