using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algrthm.Test.Array
{
    [TestClass()]
    public class EqualSidesOfAnArrayTest
    {
        [TestMethod()]
        public void GenericTests()
        {
            Assert.AreEqual(3, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
            Assert.AreEqual(-1, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] { -20, 10, 30, 10, -10, 15, -35 }));
            Assert.AreEqual(6, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] { -20, 20, -15, 10, -10, 15, -35 }));
            //Assert.AreEqual(0, Algrthm.Array.EqualSidesOfAnArray.FindEvenIndex(new int[] {}));

        }
    }
}
