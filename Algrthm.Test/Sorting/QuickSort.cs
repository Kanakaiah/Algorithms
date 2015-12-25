using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Test.Sorting
{
    [TestClass]
    public class QuickSort
    {
        [TestMethod]
        public void Sort()
        {
            Algrthm.Sorting.QuickSort<int> qSort = new Algrthm.Sorting.QuickSort<int>();
            int[] array = { 10, 45, 12, 21 , 6, 34, 9, 24, 16, 18 };

            qSort.Sort(array);


            foreach (var item in array)
            {
                System.Diagnostics.Debug.WriteLine(item);
            }

        }
    }
}
