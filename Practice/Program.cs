using System;
using FSPG;


/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          Read the Instructions.pdf file.
//          Run the example.exe to see how this program will behave.
//          Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.

namespace Practice
{
    class Program
    {
        static string[] Greetings = { "Hello there!", "Welcome to the practice!", "Hi, user!",
                                "Hey, I am a program.", "You're running the best program ever!" };

        static void Main(string[] args)
        {
            // TODO: Display a random string from the Greetings array.

            Random rdm = new Random();
            int Rnum = rdm.Next(0, Greetings.Length);
            Console.WriteLine(Greetings[Rnum]);
            //Console.ReadLine();
            //Console.Clear();

            // TODO: Ask the user for a positive number and then print the square of that number.
            //       Make sure your progarm does not crash if the user enters bad input.
            //       Make sure the user can keep entering input until they enter good input.
            double Pnum = 0;
            Console.Write("Type in a valid positive number: ");
            while (!double.TryParse(Console.ReadLine(), out Pnum) || Pnum < 1)
            {
                Console.Write("A valid positive number, pls: ");
                //double.TryParse(Console.ReadLine(), out Pnum);
            }
            Console.WriteLine(Math.Pow(Pnum, 2));
            //Console.ReadLine();
            //Console.Clear();

            // TODO: Create an array of doubles. Use a random number (in the range of 3 to 6) for the size.
            //       For each element of the array, ask the user to enter a value and store
            //       it in the array. The input does not have to be error checked.
            Random range = new Random();            //size
            double[] Darray = new double[range.Next(3, 6)];
            for (int i = 0; i < Darray.Length; i++)
            {
                Console.Write("Type in a value to store in array: ");
                Darray[i] = double.Parse(Console.ReadLine());
            }
            // TODO: Call the FindAverage method passing in the array of doubles and display
            //       the return value to the screen.
            double avg = FindAverage(Darray);
            Console.WriteLine("Here is your avg: " + avg);
            Console.ReadLine();
        }

        // TODO: Write a method called FindAverage that takes an array of doubles and returns a double
        //       Don't forget to mark the method as static.
        //public static class FindAverage
        //{
            //int length;
            //double sum;
            //double[] Tarray;
            //double average;
            //public FindAverage(double[] val , int size)
            //{
            //    length = size;
            //    Tarray = val;
            //    for (int i = 0; i < Tarray.Length; i++)
            //    {
            //        sum += Tarray[i];
            //    }
            //    average = sum / length;
            //    Console.WriteLine("Here is your avg: " + average);
            //}
            public static double FindAverage(double[] ar1)
            {
                double average=0;
                double sum = 0;
                for (int i = 0; i < ar1.Length; i++)
                {
                    sum += ar1[i];
                }
                average = sum / ar1.Length;
                return average;
            }

        //}

        // TODO: In the FindAverage method compute the average (the sum of all values divided by the number of values)
        //       of the values in the array parameter and return it.

    }
}
