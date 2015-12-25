using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Test.Interviews.MS
{
    [TestClass]
    public class WordReverse
    {

        [TestMethod]
        public void TestResult()
        {
            Algrthm.Interviews.MS.WordReverse wordReverse = new Algrthm.Interviews.MS.WordReverse();

            System.Diagnostics.Debug.WriteLine(wordReverse.GetResult("Hello How are you"));
            System.Diagnostics.Debug.WriteLine(wordReverse.GetResult(" Hello How are you"));
            System.Diagnostics.Debug.WriteLine(wordReverse.GetResult("Hello  How are you"));
            System.Diagnostics.Debug.WriteLine(wordReverse.GetResult(" Hello How   are you  "));
            
        }
    }
}
