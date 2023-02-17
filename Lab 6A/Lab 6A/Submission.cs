using System;
using System.Diagnostics.Contracts;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * You cannot use multiple return statements any of these methods. 
         * Additionally the use of var is not permitted
         * 
        */

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {
            int[] ThePhrase = new int[phrase.Length];
            for (int ichar= 0; ichar < phrase.Length; ichar++)
            {
                ThePhrase[ichar] = phrase[ichar];
            }
            return ThePhrase;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
        {
            double [] Mydata = new  double[3];
            Mydata[0] = data[0]; //smallest
            Mydata[1] = data[0]; //largest
            Mydata[2] = 0; //meen
            for (int i = 0; i < data.Length; i++)
            {
              if (Mydata[0] > data[i])
              {
                  //set smallest equal to that variable
                  Mydata[0] = data[i];
              }
              if (Mydata[1] < data[i])
              {
                  //set smallest equal to that variable
                  Mydata[1] = data[i];
              }
           
           
              //if largest is < data[i]
              //replace largest
           
                Mydata[2] += data[i];
            }
            Mydata[2] = Mydata[2] / data.Length;
            return Mydata;
            

        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double Largest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Largest < numbers[i])
                {
                    Largest = numbers[i];
                }
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = numbers[j] / Largest;
            }

        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        public static bool Test4(string [] names)
        {
            //nested for loops through names
            //DON'T USE this is example to learn and take notes on
            //int[] temp = new int[10];
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    for (int j = i+1; j < temp.Length; j++)
            //    {
            //        if (temp[i] == temp[j])
            //        { 
            //
            //        }
            //    }
            //}
            //just return bool in the loop
            bool TheTruth = true;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {
                        TheTruth = false;
                    }
                }
            }
            return TheTruth;
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {
            //Learning example
            //int[] temp = new int[2];
            //temp[0] = 0;
            //int tmp1;
            //
            //string temp2 = "hiya";
            //char tmp = temp2[0];
            //
            //
            //tmp = words[0][0];
            string acronym = "";
            for (int i = 0; i < words.Length; i++)
            {
                acronym += words[i][0];
            }
           return acronym;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            //Example to study
            // char[] reverse = new char[letters.Length];
            // int i = letters.Length - 1;
            // //for loop j through letters
            //     //for
            //         //reverse j  = letters i
            //             //i--
            //
            //         //dont use nested forloops for this problem won't work
            //     //reverse for loop
            // for (int i = 0; i < length; i++)
            // {
            //
            // }
            char[] reverse = new char[letters.Length];
            int i = 0;
            for (int j = letters.Length - 1 ; j > -1; j--)
            {
                reverse[i++] = letters[j];
            }
            return reverse;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //
        public static int[,] Test7(int [,] table)
        {                                       //this way because it is transposed
                                                // int[,] temp = new int[table.GetLength(1),table.GetLength(0)];
                                                //
                                                // //for x table's x
                                                // //for y table's y
                                                //     temp[y,x] = table[x,y]
            int[,] Ttable = new int[table.GetLength(1), table.GetLength(0)];
            for (int x = 0; x < table.GetLength(0); x++)
            {
                for (int y = 0; y < table.GetLength(1); y++)
                {
                    Ttable[y, x] = table[x, y];
                }
            }
           return Ttable;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // 
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
            // int[,] temp = new int[3,mins.Length];
            // //for loop through mins.length
            //     //temp[0, i] = mins[i];
            //     //temp[1,i] = maxes[i];
            //     NOTE the order of input for the arrays matters min then maxes then seeds
            int[,] combo = new int[3, mins.Length];
            for (int i = 0; i < mins.Length; i++)
            {
                combo[0, i] = mins[i];
                combo[1, i] = maxes[i];
                combo[2, i] = seeds[i];

            }
            return combo;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
            // //same as test 1 in this lab 
            // char temp = (char)ascii[0];
            char[] iicsa = new char[ascii.Length];
            for (int i = 0; i < ascii.Length; i++)
            {
                iicsa[i] = (char)ascii[i];
            }
            return iicsa;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
            //loop through word
            //if check
            // check for even or odd with mod
            //i%2 !=0
            //  word[0] = char.ToLower[word[0]];
            //add 32 for math version of changing a char value to lowercase values

            for (int i = 0; i < word.Length; i++)
            {
                if(i%2 != 0)
                {
                    word[i] = char.ToLower(word[i]);
                }
            }
        }
    }
}
