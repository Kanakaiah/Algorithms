using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Interviews.MS
{
    
    public class WordReverse
    {
        public string GetResult(string str)
        {
            int startIndex = 0;
            string result = string.Empty;

            for (int i = 0; i <str.Length-1; i++)
            {
                if(str[i]==' ')
                {

                    if (startIndex == 0)
                    {
                        if (i == 0)
                        {
                            result = " ";
                            startIndex += 1;
                        }
                        else
                        {
                            result = " " + str.Substring(startIndex, i);
                            startIndex = i + 1;
                        }
                    }
                    else
                    {

                        if (startIndex == i)
                        {
                            result = " " + result;
                            startIndex += 1;
                        }
                        else
                        {
                            result = " " + str.Substring(startIndex, i-startIndex)+ result;
                            startIndex =i+1;
                        }

                    }
                }
            }

            if(str.Length!=result.Length)
            result = str.Substring(startIndex, str.Length - startIndex) + result;


            return result;

        }

    }
}
