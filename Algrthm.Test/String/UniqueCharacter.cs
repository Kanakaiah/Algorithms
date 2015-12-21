using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Test.String
{
    [TestClass()]
    public class UniqueCharacter
    {
        [TestMethod()]
        public void IsUnique()
        {
            Debug.WriteLine(
            Algrthm.String.UniqueCharacter.IsUnique("abcdefghijk") ? "true" : "false"
            );
        }

    }
}
