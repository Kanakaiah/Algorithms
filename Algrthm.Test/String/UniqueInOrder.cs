using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Test.String
{
    class UniqueInOrder
    {
        [TestClass()]
        public class SolutionTest
        {
            [TestMethod()]
            public void EmptyTest()
            {
                Assert.AreEqual("", string.Concat(Algrthm.String.UniqueInOrder.GetUniqueInOrder("")));
            }

            [TestMethod()]
            public void Test1()
            {

                Assert.AreEqual("ABCDAB", string.Concat(Algrthm.String.UniqueInOrder.GetUniqueInOrder("AAAABBBCCDAABBB")));
            }


            [TestMethod()]
            public void Test2()
            {
                Assert.AreEqual("ABCcAD", string.Concat(Algrthm.String.UniqueInOrder.GetUniqueInOrder("ABBCcAD")));
            }

            [TestMethod()]
            public void Test3()
            {
                Assert.AreEqual("123", string.Concat(Algrthm.String.UniqueInOrder.GetUniqueInOrder("12233")));
            }

            [TestMethod()]
            public void Test4()
            {
                var actual= Algrthm.String.UniqueInOrder.GetUniqueInOrder(new List<double> { 1.1, 2.2, 2.2, 3.3 }).ToList();
                var expected = new List<double> {1.1, 2.2, 3.3};

                CollectionAssert.AreEqual(expected, actual);
            }

        }
    }
}
