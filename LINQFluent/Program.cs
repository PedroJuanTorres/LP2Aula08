using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("livro.txt");

            /*int nl = fileLines.Count(line => line.Length > 30);
            Console.WriteLine($"Lines > 30 : {nl}");

            double avg = fileLines.Average(line => line.Length);
            Console.WriteLine($"Average chars: {avg}");

            Console.WriteLine($">120? {fileLines.Any(line => line.Length > 120)}");

            IEnumerable<string> a = fileLines.Where(line => line.Contains("Y"))
                                              .Select(line => line.Trim().Split()?[0].ToUpper());

            foreach (string s in a)
            {
                Console.WriteLine(s);
            }*/

            int nl =(from line in fileLines
                     where line.Length > 30
                     select line).Count();

            double avg =(from line in fileLines 
                         select line.Length).Average();

            bool b =(from line in fileLines
                     where line > 120
                     select line).Any();

            IEnumerable<string> a = from line in fileLines
                                    where line.Contains("Y")
                                    select line.Trim().Split()[0].ToUpper();
        }
    }
}
