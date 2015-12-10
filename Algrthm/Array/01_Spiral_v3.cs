using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm_DS.Array
{
    public class _01_Spiral_v3
    {
        public static int[,] GetSpiral(int x)
        {
            int[,] intArray = new int[x, x];

            int r1 = 0, r2 = x, c1 = 0, c2 = x, counter=1;

            while (r1<r2 && c1< c2)
            {
                //---->
                for (int i =r1; i < c2; i++)
                {
                    intArray[r1, i] = counter;
                    counter++;
                }
                r1++;

                // |
                // |
                // V
                for (int i = r1; i < r2; i++)
                {
                    intArray[i, c2-1] = counter;
                    counter++;
                }
                c2--;

                // <-----
                if (r1 < r2)
                {
                    for (int i = c2-1; i >= c1; i--)
                    {
                        intArray[r2 - 1, i] = counter;
                        counter++;
                    }
                    r2--;
                }

                // ^
                // |
                // |
                if (c1 < c2)
                {
                    for (int i = r2-1; i >= r1; i--)
                    {
                        intArray[i, c1] = counter;
                        counter++;
                    }
                    c1++;
                }

            }
            return intArray;
        }
    }
}
