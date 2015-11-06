using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_DS_2015
{

    public delegate int Transformer(int x);


    public class DelegatePlugin
    {

        public void Transform(ref int[] array, Transformer t)
        {
            for (int i=0;i<array.Length;i++)
            {
                array[i] = t(array[i]);
            }
        }

        public int Sqaure(int x) => x* x;
    }
}
