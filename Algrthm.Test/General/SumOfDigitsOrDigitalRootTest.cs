using Algrthm.General;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Algrthm.Test.General
{
    [TestClass()]
    public class SumOfDigitsOrDigitalRootTest
    {
        [TestMethod()]
        public void NumberTest()
        {
            var actual = SumOfDigitsOrDigitalRoot.DigitalRoot(16);
            Assert.AreEqual(7, actual);

            actual = SumOfDigitsOrDigitalRoot.DigitalRoot(942);
            Assert.AreEqual(6, actual);

            actual = SumOfDigitsOrDigitalRoot.DigitalRoot(132189);
            Assert.AreEqual(6, actual);

            actual = SumOfDigitsOrDigitalRoot.DigitalRoot(493193);
            Assert.AreEqual(2, actual);
            
        }
    }
    
}
