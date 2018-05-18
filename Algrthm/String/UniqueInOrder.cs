﻿using System.Collections.Generic;

namespace Algrthm.String
{
    public static class UniqueInOrder
    {

        public static IEnumerable<T> GetUniqueInOrder<T>(IEnumerable<T> iterable)
        {
            //List<T> returnResult = new List<T>();

            //T prevItem = default(T);

            //int iteration = 0;
            //foreach (var item in iterable)
            //{


            //    if (iteration == 0)
            //    {
            //        prevItem = item;
            //        returnResult.Add(item);
            //        iteration++;
            //    }
            //    else
            //    {
            //        if (!item.Equals(prevItem))
            //        {
            //            prevItem = item;
            //            returnResult.Add(item);
            //            iteration++;
            //        }
            //    }
            //}

            //return returnResult;
            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }
    }
}

/*
Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
   
   For example:

// Note that you can return any data structure you want, as long it inherits the IEnumerable interface.
   UniqueInOrder("AAAABBBCCDAABBB")                     => "ABCDAB"
   UniqueInOrder("ABBCcAD")                             => "ABCcAD"
   UniqueInOrder("12233")                               => "123"
   UniqueInOrder(new List<double> {1.1, 2.2, 2.2, 3.3}) => new List<double> {1.1, 2.2, 3.3}


 */
