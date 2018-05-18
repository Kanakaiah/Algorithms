using Algrthm.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Algrthm.Test.String
{
        [TestClass()]
    public class ExesAndOhsTest
    {
        [TestMethod()]
        public void ExampleTests()
        {
            var actual = ExesAndOhs.XO("xo");
            const bool expected = true;
            Assert.AreEqual(expected, actual);
            actual = ExesAndOhs.XO("xxOo");
            Assert.AreEqual(expected, actual);
            actual = ExesAndOhs.XO("xxxm");
            Assert.AreEqual(!expected, actual);
            actual = ExesAndOhs.XO("Oo");
            Assert.AreEqual(!expected, actual);
            actual = ExesAndOhs.XO("ooom");
            Assert.AreEqual(!expected, actual);
        }

    }
}
