using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.String
{
    public static class JadenCase
    {

        public static string ToJadenCase(this string phrase)
        {
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(phrase);

            //1
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);

            //2
            //return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));

            //3
            //char[] a = phrase.ToLower().ToCharArray();

            //for (int i = 0; i < a.Count(); i++)
            //{
            //    a[i] = i == 0 || a[i - 1] == ' ' ? char.ToUpper(a[i]) : a[i];

            //}

            //return new string(a);


        }
    }
}

/*
 Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). Jaden is also known for some of his philosophy that he delivers via Twitter. When writing on Twitter, he is known for almost always capitalizing every word.
   Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.
   Example:
   Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
   Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

*/
