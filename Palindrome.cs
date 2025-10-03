using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Palindrome
    {
        public static bool sPalindrome(string text)
        {
            string check = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                check += text[i];
            }

            return text == check;
        }

    }
}
