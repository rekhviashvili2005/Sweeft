using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Brackets
    {

        // #### 4444 ფრჩხილების დაბრუნება
        public static bool IsProperly(string txt)
        {


            int a = 0;
            int b = 0;

            foreach (char i in txt)
            {
                if (i == '(')
                    a++;
            }
            foreach (char i in txt)
            {
                if (i == ')')
                    b++;
            }

            int frchxilebi = a + b;

            if (a == 0 || b == 0)
            {
                return false;
            }
            else
            {
                if (frchxilebi / a == 2)
                    return true;
            }

            return false;

        }
    }
}
