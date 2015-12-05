using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm_DS.Array
{
    public class _01_Spiral_v2
    {
        /*Given a 2D array, print it in spiral form. See the following examples.*/
        public static string GetSpiral(int[,] a)
        {
            int erow = a.GetLength(0); 
            int ecol= a.GetLength(1);
            string result = string.Empty;
            int i, srow = 0, scol = 0;

            /*  k - starting row index
                r - ending row index
                l - starting column index
                c - ending column index
                i - iterator
            */

            while (srow < erow && scol < ecol)
            {
                /* Print the first row from the remaining rows */
                for (i = scol; i < ecol; ++i)
                {
                    result+=" "+a[srow,i].ToString();
                }
                srow++;

                /* Print the last column from the remaining columns */
                for (i = srow; i < erow; ++i)
                {
                    result+=" "+a[i, ecol - 1].ToString();
                }
                ecol--;

                /* Print the last row from the remaining rows */
                if (srow < erow)
                {
                    for (i = ecol - 1; i >= scol; --i)
                    {
                        result+=" "+a[erow - 1,i].ToString();
                    }
                    erow--;
                }

                /* Print the first column from the remaining columns */
                if (scol < ecol)
                {
                    for (i = erow - 1; i >= srow; --i)
                    {
                        result+=" "+a[i, scol].ToString();
                    }
                    scol++;
                }
            }
            return result;
        }

    }
}
