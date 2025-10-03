using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class MinArrays
    {
        
       
        
            public static int NotContains(int[] array)
            {
                int shedegi = 0;
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min && array[i] != 0)
                        min = array[i];
                }
                if (min - 1 == 0)
                {
                    shedegi = min + 1;
                    bool gavimeore = true;
                    while (gavimeore)
                    {
                        gavimeore = false;
                        foreach (int i in array)
                        {
                            if (shedegi == i)
                            {
                                shedegi += 1;
                                gavimeore = true;
                                break;
                            }
                        }
                    }
                }
                return shedegi;
            }
        

    }
}
