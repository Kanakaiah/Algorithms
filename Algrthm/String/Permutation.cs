using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.String
{
    public class Permutation
    {
        public static bool AreThesePermutation(string s, string m)
        {
            int[] charset = new int[128];

            for (int i = 0; i < s.Length; i++)
            {

                charset[s[i]]++;
            }

            for (int i = 0; i < m.Length; i++)
            {
                charset[m[i]]--;

                if (charset[m[i]] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
