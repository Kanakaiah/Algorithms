using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Array
{
    public static class _01_Spiral
    {
        public static string GetFromArray(int[,] input)
        {
            int row = input.GetLength(0); //3
            int col = input.GetLength(1); //3

            int counter = 0; byte direction = 1;
            string result = string.Empty;
            while (counter <= (row % 2 + row / 2))
            {
                traverse(ref row, ref counter, ref result, ref direction, input);
                counter += 1;
            }

            return result.Trim();
        }

        public static void traverse(ref int row, ref int counter, ref string result, ref byte direction, int[,] input)
        {
            byte isMatrixOddNum = 0;

            if (direction == 1)
                for (int i = counter; i < row - 1; i++)
                {
                    result += input[counter, i].ToString() + " ";
                    direction = 2; //row -= 1;
                    isMatrixOddNum = 1;
                }
            if (direction == 2)
                for (int i = counter; i < row - 1; i++)
                {

                    result += input[i, row - 1].ToString() + " ";
                    direction = 3;

                }
            if (direction == 3)
                for (int i = row - 1; i > counter; i--)
                {
                    result += input[row - 1, i].ToString() + " ";
                    direction = 4;

                }
            //if (row <= 3)
            //    direction = 1;
            if (direction == 4)
                for (int i = row - 1; i > counter; i--)
                {
                    result += input[i, counter].ToString() + " ";
                    direction = 1;
                }

            if(isMatrixOddNum==0)
            {
                result += input[row-1, row-1].ToString() + " ";
            }
            row -= 1;

        }
    }
}




/*
string[,] Tablero = new string[3, 3] {{"a","b","c"},
                                      {"d","e","f"}, 
                                      {"g","h","i"} };
*/
