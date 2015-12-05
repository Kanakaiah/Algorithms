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
    public class _01_SpiralTests
    {
        [TestMethod()]
        public void GetFromArrayTest1()
        {
            string[,] Tablero = new string[6, 6] {{"00","01","02","03","04","05"},
                                                  {"19","20","21","22","23","06"},
                                                  {"18","31","32","33","24","07"},
                                                  {"17","30","35","34","25","08"},
                                                  {"16","29","28","27","26","09"},
                                                  {"15","14","13","12","11","10"}
            };

            string expectedResult = "00->01->02->03->04->05->06->07->08->09->10->11->12->13->14->15->16->17->18->19->20->21->22->23->24->25->26->27->28->29->30->31->32->33->34->35->";
            string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult);

        }

        [TestMethod()]
        public void GetFromArrayTest2()
        {
            string[,] Tablero = new string[4, 4] {{"01","02","03","04"},
                                                  {"12","13","14","05"},
                                                  {"11","16","15","06"},
                                                  {"10","09","08","07"}
            };

            string expectedResult = "01->02->03->04->05->06->07->08->09->10->11->12->13->14->15->16->";
            string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult);

        }


        [TestMethod()]
        public void GetFromArrayTest3()
        {
            string[,] Tablero = new string[5, 5] {{"01","02","03","04","05"},
                                                  {"16","17","18","19","06"},
                                                  {"15","24","25","20","07"},
                                                  {"14","23","22","21","08"},
                                                  {"13","12","11","10","09"}
            };

            string expectedResult = "01->02->03->04->05->06->07->08->09->10->11->12->13->14->15->16->17->18->19->20->21->22->23->24->25->";
            string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult);

        }
        [TestMethod()]
        public void GetFromArrayTest4()
        {
            string[,] Tablero = new string[,] {{"01","02","03","04","05","06"},
         {"07","08","09","10","11","12"},
        {"13","14","15","16","17","18"}};


            string expectedResult = "01->02->03->04->05->06->12->18->17->16->15->14->13->7->8->9->10->11->";
            string actualResult = Algrthm_DS.Array._01_Spiral.GetFromArray(Tablero);


            Assert.AreEqual<string>(expectedResult, actualResult);

        }
        
    }
}