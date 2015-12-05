using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algrthm_DS.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm_DS.Array.Tests
{
    [TestClass()]
    public class _1_SpiralTests
    {
        [TestMethod()]
        public void GetFromArrayTest1()
        {
            int[,] Tablero = new int[6, 6] {{0,1,2,3,4,5},
                                                  {19,20,21,22,23,6},
                                                  {18,31,32,33,24,7},
                                                  {17,30,35,34,25,8},
                                                  {16,29,28,27,26,9},
                                                  {15,14,13,12,11,10}
            };

            string expectedResult = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35";
            //string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);
            string actualResult = Algrthm_DS.Array._01_Spiral_v2.GetSpiral(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult.Trim());

        }

        [TestMethod()]
        public void GetFromArrayTest2()
        {
            int[,] Tablero = new int[4, 4] {{1,2,3,4},
                                                  {12,13,14,5},
                                                  {11,16,15,6},
                                                  {10,9,8,7}
            };

            string expectedResult = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16";
            //string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);
            string actualResult = Algrthm_DS.Array._01_Spiral_v2.GetSpiral(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult.Trim());

        }


        [TestMethod()]
        public void GetFromArrayTest3()
        {
            int[,] Tablero = new int[5, 5] {{1,2,3,4,5},
                                                  {16,17,18,19,6},
                                                  {15,24,25,20,7},
                                                  {14,23,22,21,8},
                                                  {13,12,11,10,9}
            };

            string expectedResult = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25";
            //string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);
            string actualResult = Algrthm_DS.Array._01_Spiral_v2.GetSpiral(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult.Trim());

        }
        [TestMethod()]
        public void GetFromArrayTest4()
        {
            int[,] Tablero = new int[,] {{1,2,3,4,5,6},
         {7,8,9,10,11,12},
        {13,14,15,16,17,18}};


            string expectedResult = "1 2 3 4 5 6 12 18 17 16 15 14 13 7 8 9 10 11";
            string actualResult = Algrthm_DS.Array._01_Spiral_v2.GetSpiral(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult.Trim());

        }





        
    }
}