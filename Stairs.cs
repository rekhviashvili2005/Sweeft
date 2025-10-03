using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Stairs
    {
        // ### 555 კიბეები
        public static int CountVariants(int stairCount)
        {
            if (stairCount <= 1)
                return 1;
            if (stairCount == 2)
                return 2;

            int prev2 = 1;
            int prev1 = 2;
            int current = 0;

            for (int i = 3; i <= stairCount; i++)
            {
                current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }
            return current;
        }

    }
}
