using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hey. Welcome to Programming 1. Good luck, you'll need it.");
            Console.Write("\nWhat is your facorite food? ");
            string food = Console.ReadLine().ToUpper();



            Console.WriteLine("So your favorite food is " + food.ToUpper() + " huh? Kinda gross ngl.");

            Console.Write("Oh, how old are you btw? ");
            string strAge = Console.ReadLine();

            //strAge.

            int nAge = int.Parse( Console.ReadLine() );
            Console.WriteLine("Wow, " + nAge + " is pretty old. That's like " + nAge * 365 +" days. No wonder you like " + food);

            //annoying beeps
            //Console.Beep(120, 300);
            //Console.Beep(4000,100);
            Console.WriteLine("\n\n\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
