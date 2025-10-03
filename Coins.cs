using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Coins
    {
        public static int MinSplit(int amount)
        {
            int[] coins = { 50, 20, 10, 5, 1 };
            int coinCount = 0;

            foreach (int coin in coins)
            {
                coinCount += amount / coin;
                amount %= coin;
            }
            return coinCount;
        }

    }
}
