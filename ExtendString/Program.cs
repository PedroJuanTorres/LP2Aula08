using System;

namespace ExtendString
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s.ToRandomCase());
            }      
        }
    }
}
