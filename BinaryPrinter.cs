using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft._9_davaleba
{
    public class BinaryPrinter
    {

        private readonly SemaphoreSlim semaphore;
        private readonly Random random = new Random();

        public BinaryPrinter(SemaphoreSlim semaphore)
        {
            this.semaphore = semaphore;
        }

        public async Task PrintBinaryNumbers()
        {
            while (true)
            {
                await semaphore.WaitAsync();

                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(random.Next(0, 2));
                    Console.ResetColor();
                    await Task.Delay(50);
                }
                finally
                {
                    semaphore.Release();
                }

                await Task.Delay(10);
            }
        }
    }
}
