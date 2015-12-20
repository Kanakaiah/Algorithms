using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.LanguageFeatures
{
    public class NestedType
    {
        public enum Color
        {
            Red,
            Green,
            Tan
        }

        public class NestedLevel1
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}
