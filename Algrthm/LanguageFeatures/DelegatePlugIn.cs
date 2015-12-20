using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.LanguageFeatures
{
    public delegate int Transformer(int x);
    public class DelegatePlugin
    {

        public void Transform(ref int[] array, Transformer t)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = t(array[i]);
            }
        }


        public void Transform1(ref int[] array, Func<int, int> t)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = t(array[i]);
            }
        }

        public int Sqaure(int x) => x * x;




    }
}
