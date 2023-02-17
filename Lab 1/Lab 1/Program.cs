using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Full Sail!");
            Console.Write("Your Name? ");
            string strName = Console.ReadLine();

            Console.Write("Hey, " + strName + ". How old are you? ");
            string strAge = Console.ReadLine();

            Console.WriteLine("Well hello, " + strName + ". Must be great to be " + strAge + " and be attending Full Sail.");


            Console.ReadKey();
        }
    }
}
