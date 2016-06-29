using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math.MathClasses;
using System.Diagnostics;

namespace Math
{
    class Program
    {
        private static readonly string _closeOut = "-------------------------------------";
        //Add and Subtract necesarry methods with bool flags
        //Fibonnaci 
        private static readonly bool IS_FIBONNACI_SIMPLE = false;
        private static readonly bool IS_FIBONNACI_SHOW_TERMS = false;
        private static readonly bool IS_EVEN_FIBONNACI_NUMBERS = false;
        // Prime factors
        private static readonly bool IS_LARGEST_PRIME_FACTOR_RECURSIVE = false;
        private static readonly bool IS_LARGEST_PRIME_FACTOR_QUICKER = false;
        // Palindrome
        private static readonly bool IS_PALINDROME_3_DIGITS_RECURSIVE = false;
        private static readonly bool IS_PALINDROME_3_DIGITS_QUICKER = false;
        //Smallest Multiple
        private static readonly bool IS_SMALLEST_MULTIPLE_RANGE_GCD_EUCLIDEAN = false;
        // Sum Square Difference 
        private static readonly bool IS_SUM_SQUARE_DIFFERENCE = true;

        static void Main(string[] args)
        {
            #region Fibonnaci
            if (IS_FIBONNACI_SIMPLE == true)
            {
                Fibonnaci f = new Fibonnaci();
                Console.WriteLine("Input a desired Fibonnaci number: ");
                string value = Console.ReadLine();
                Console.WriteLine(value + " Fibonnaci number! " + f.Fibonacci(Convert.ToInt32(value)));
                if (IS_FIBONNACI_SHOW_TERMS == true)
                {
                    for (int i = 0; i < Convert.ToInt32(value); i++)
                    {
                        Console.WriteLine(f.Fibonacci(i));
                    }
                }
                Console.WriteLine(_closeOut);
            }

            if (IS_EVEN_FIBONNACI_NUMBERS == true)
            {
                Fibonnaci f = new Fibonnaci();
                Console.WriteLine("Input Number of Terms");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                Console.WriteLine(value + "" + f.SumOfEvenFibonnaciTerms(Convert.ToInt32(value)));
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region LargestPrime
            if (IS_LARGEST_PRIME_FACTOR_RECURSIVE)
            {
                Stopwatch sw = new Stopwatch();
                LargestPrimeFactor lfp = new LargestPrimeFactor();
                Console.WriteLine("Input Number you want the Largest Prime factor of");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Largest Prime factor: " + lfp.LargestPrimeFactorSlow(Convert.ToInt64(value)));
                sw.Stop();
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }

            if (IS_LARGEST_PRIME_FACTOR_QUICKER)
            {
                Stopwatch sw = new Stopwatch();
                LargestPrimeFactor lfp = new LargestPrimeFactor();
                Console.WriteLine("Input Number you want the Largest Prime factor of");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Largest Prime factor: " + lfp.LargestPrimeFactorFaster(Convert.ToInt64(value)));
                sw.Stop();
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Palindrome
            if (IS_PALINDROME_3_DIGITS_RECURSIVE)
            {
                Stopwatch sw = new Stopwatch();
                Palindrome p = new Palindrome();
                Console.WriteLine("Calculating largest Palindrome from the product of two 3 digit numbers (recursive):");
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Answer: " + p.LargestPalindromeThreeDigitsRecursive());
                sw.Stop();
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }

            if (IS_PALINDROME_3_DIGITS_QUICKER)
            {
                Stopwatch sw = new Stopwatch();
                Palindrome p = new Palindrome();
                Console.WriteLine("Calculating largest Palindrome from the product of two 3 digit numbers (p builder):");
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Answer: " + p.LargestPalindromeThreeDigitsQuicker());
                Console.WriteLine("Made by multiplying " + p.Factor + " and " + p.Factor1);
                sw.Stop();
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region SmallestMultiple

            if (IS_SMALLEST_MULTIPLE_RANGE_GCD_EUCLIDEAN)
            {
                Stopwatch sw = new Stopwatch();
                SmallestMultiple sm = new SmallestMultiple();
                Console.WriteLine("Enter Max number for range of Smallest Multiple (starts at 1): ");
                Console.WriteLine(_closeOut);
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Answer: " + sm.SmallestMultipleByRange(Convert.ToInt32(value)));
                sw.Stop();
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }

            #endregion

            #region SumSquareDifference
            if (IS_SUM_SQUARE_DIFFERENCE)
            {
                Stopwatch sw = new Stopwatch();
                SumSquareDifference ssd = new SumSquareDifference();
                Console.WriteLine("Input Max Natural Number: ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Square of Sums: " + ssd.squareSum(Convert.ToInt32(value)));
                Console.WriteLine("Sum of Square: " + ssd.sumSquare(Convert.ToInt32(value)));
                Console.WriteLine("Sum Square Difference: " + ssd.SumSquareDifferenceAnswer(Convert.ToInt32(value)));
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }

            #endregion
            Console.ReadLine();
        }
    }
}
