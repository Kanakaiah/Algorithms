using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using   Algrthm.String;

namespace Algrthm.Test.String
{
    [TestClass()]
    public class JadenCaseTest
    {

        [TestMethod()]
        public void EmptyTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                "Strings didn't match.");
        }
    }
}
