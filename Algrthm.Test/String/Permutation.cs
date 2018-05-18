using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Test.String
{
    [TestClass]
    public class Permutation
    {
        [TestMethod]
        public void AreThese()
        {

            Debug.WriteLine(Algrthm.String.Permutation.AreThesePermutation("Man   ", "   naM"));

            Assert.AreEqual(true, Algrthm.String.Permutation.AreThesePermutation("Man   ", "   naM"));

        }

    }
}
