using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.String
{
    public class UniqueCharacter
    {

        public static bool IsUnique(string inpt)
        {
            int charset = 0;

            for (int i = 0; i < inpt.Length; i++)
            {
                int val = (int)inpt[i] - 'a';

                if ((charset & (1 << val))>0)
                {
                    return false;
                }
                else
                {
                    charset |= (1 << val);
                }
            }
            return true;
        }
    }
}
