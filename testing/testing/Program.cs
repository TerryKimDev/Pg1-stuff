using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Steve";

            int result = name.CompareTo("Steve");

            Console.WriteLine(result);
            int[] array = { 1, 3, 5, 4, 10 }; Console.WriteLine(array[7 % 3]);

            Dictionary<string, string> minivans = new Dictionary<string, string>()

{

    { "Ford", "Aerostar" },

    { "Honda", "Odyssey"},

    { "Toyota", "Sienna"}

};

            if (minivans.TryGetValue("Nissan", out string model))

            {

                Console.WriteLine($"Nissan Model: {model}");

            }
            string text = "I am Batman!";

            string[] splits = text.Split(' ');

            Console.Write(splits[2][2]);

            Console.ReadKey();



            /*
            bool sev = true;
            do
            {
                sev = !sev;
                Console.WriteLine(sev);
                Console.WriteLine("exit Y/n");
            } while ('Y' != Console.ReadLine().ToUpper()[0]);
            */
            //int[] coins = { 25, 10, 5, 1 };
            //int amount, count, i;
            //Console.Write("Enter the amount you want to change : ");
            //amount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("==========================");
            //for (i = 0; i < coins.Length; i++)
            //{
            //    count = amount / coins[i];
            //    if (count != 0)
            //        Console.WriteLine("Count of {0} cent(s) :{1}", coins[i], count);
            //    amount %= coins[i];
            //}
            //
            //static void Main(string[] args)
            /*
            {

                int x = 5;

                Add10(x);

                Console.Write(x);

            }
            */

            //Console.ReadLine();
            //int coins;
            //double amount;
            //double count = 0;
            //double num = 0;
            //double coin =0;
            //Console.WriteLine("enter amount");
            //amount = Convert.ToDouble(Console.ReadLine());

            //while (true)
            //{
            //    if (amount >= .25)
            //    {
            //        count = amount / .25;
            //        num = count * amount;
            //        coin %= amount;
            //        //amount %= count;
            //    }

            //else if (amount >= .10)
            //{
            //    count %= amount / .10;
            //}
            //else if (amount >= .05)
            //{
            //    count %= amount / .05;
            //}
            //else if (amount >= .01)
            //{
            //    count %= amount / .01;
            //}

            // break;
            //}
            //Console.Write( Convert.ToString(coin));

            Console.ReadKey();
        }
        class Animal

        {

            public void Show() { Console.Write("Animal"); }

        }

        class Dog : Animal

        {

            public void Show() { base.Show(); Console.Write("Dog"); }

        }
        static void Add10(int x)

        {

            x += 10;

        }

    }
}
