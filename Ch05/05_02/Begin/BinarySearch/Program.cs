using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a binary search for {theValue} is: ");
            WriteLine(binarySearch(array, theValue));


        }

        /// <summary>
        /// a = array
        /// x = what we're searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int binarySearch(int[] a, int x)
        {
            // Step 1 - initialize the variables 
            int p = 0; // beginning of the range
            int r = a.Length - 1; // the end of hte range aka last slot

            // Step 2 - search for our value
            while (p <= r) 
            {
                int q = (p + r) / 2; // find midpoint
                if (x < a[q])
                {
                    r = q - 1; // set r to midpoint.we narrowed to 1st half of the array in the case x is less than data in slot q
                }
                else if (x > a[q])
                {
                    p = q + 1;
                }
                else
                {
                    return q;
                }
            }

            // Step 3 - indicate nothing found
            return -1;
        }
    }
}
