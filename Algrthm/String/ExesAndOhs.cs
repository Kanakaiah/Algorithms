using System.Linq;

namespace Algrthm.String
{
    public static class ExesAndOhs
    {
        public static bool XO(string input)
        {
            input = input.ToLower();
            return (input.Contains('x') && input.Contains('o'))
                ? ((input.Length - input.Replace("x", "").Length) == (input.Length - input.Replace("o", "").Length))
                : (!input.Contains('x') && !input.Contains('o'));

            //1
            //return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');


            //2
            //var balance = 0;

            //foreach (var ch in input)
            //{
            //    switch (ch)
            //    {
            //        case 'X':
            //        case 'x':
            //            balance -= 1;
            //            break;

            //        case 'O':
            //        case 'o':
            //            balance += 1;
            //            break;
            //    }


            //}
        }
    }
}