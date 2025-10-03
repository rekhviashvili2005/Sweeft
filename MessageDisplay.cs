using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft._9_davaleba
{
    public class MessageDisplay
    {
        private readonly SemaphoreSlim semaphore;

        public MessageDisplay(SemaphoreSlim semaphore)
        {
            this.semaphore = semaphore;
        }

        public async Task ShowPeriodicMessage()
        {
            while (true)
            {
                await Task.Delay(5000);

                await semaphore.WaitAsync();

                try
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Neo, you are the chosen one");
                    Console.ResetColor();
                    await Task.Delay(5000);
                    Console.WriteLine();
                }
                finally
                {
                    semaphore.Release();
                }
            }
        }

    }
}
