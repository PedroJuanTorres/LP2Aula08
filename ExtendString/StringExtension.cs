using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendString
{
    public static class StringExtension
    {
        private static Random rnd;
        static StringExtension()
        {
            rnd = new Random();
        }
        public static string ToRandomCase(this string s)
        {
            StringBuilder newString = new StringBuilder("", 50);

            foreach (char c in s)
            {
                if (rnd.NextDouble() < 0.5)
                {
                    newString.Append(char.ToLower(c));
                }
                else
                {
                    newString.Append(char.ToUpper(c));
                }
            }

            return newString.ToString();
        }
    }
}