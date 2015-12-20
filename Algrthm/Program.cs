using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm_DS
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. ClassVirtual
            //Community cmm = new Community() {Name="Mansion",Mortagage=250000,MortagageShare=270000 };
            //Asset asst = cmm;
            //House house = cmm;
            //Console.WriteLine(asst.Liability);
            //Console.WriteLine(house.Liability);
            //Console.WriteLine(cmm.Liability);

            //2.
            //NestedType nsType = new NestedType();
            //Print(NestedType.Color.Green);
            //NestedType.NestedLevel1 nslevel1 = new NestedType.NestedLevel1() {Name="Jesus Christ",Id=7 };
            //Print(nslevel1.Name + " " + nslevel1.Id.ToString());

            //3.
            //DelegatePlugin dp = new DelegatePlugin();
            //int[] intval = { 1, 2, 3 };
            //dp.Transform(ref intval, dp.Sqaure);

            //foreach (var item in intval)
            //{
            //    Print(item);
            //}

            //Print("--------------------------");
            //dp.Transform1(ref intval, dp.Sqaure);
            //foreach (var item in intval)
            //{
            //    Print(item);
            //}

            Transformer t = Square;
            int[] values = { 1, 2, 3, 4, 5 };
            Transform(values, t);
            foreach (var item in values)
            {
                Print(item);
            }

            Console.Read();
        }

        public delegate int Transformer(int x);

        public static int Square(int x)
        {
            return x * x;
        }

        public static void Transform(int[] values, Transformer T)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = T(values[i]);
            }
        }


        public static void Print<T>(T val)
        {
            Console.WriteLine(val);
        }
    }
}
