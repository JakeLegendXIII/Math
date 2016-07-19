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
        // Multiples of 3 and 5
        private static readonly bool IS_MULTIPLES_3_5 = false;
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
        private static readonly bool IS_SUM_SQUARE_DIFFERENCE = false;
        // Find Prime
        private static readonly bool IS_FIND_PRIME_BY_NUMBER = false;
        // Largest Product in Series
        private static readonly bool IS_LARGEST_PRODUCT_IN_SERIES = false;
        // Pythagorean Triplet
        private static readonly bool IS_PYTHAGOREAN_TRIPLET = false;
        // Summation of Primes
        private static readonly bool IS_SUMMATION_OF_PRIMES = false;
        //Largest Product in Grid
        private static readonly bool IS_LARGEST_PRODUCT_IN_GRID = false;
        //Highly divisible triangular number
        private static readonly bool IS_HIGHLY_DIVISIBLE_TRIANGLE_NUMBER = false;
        // Large Sum
        private static readonly bool IS_LARGE_SUM = false;
        // Longest Collatz Sequence
        private static readonly bool IS_LONGEST_COLLATZ = false;
        // Latice Path
        private static readonly bool IS_LATTICE_PATH = false;
        // Power digit sum
        private static readonly bool IS_POWER_DIGIT_SUM = false;
        // Number Letter Counts
        private static readonly bool IS_NUMBER_LETTER_COUNTS = false;
        // Maximum path sum 1
        private static readonly bool IS_MAX_PATH_SUM = false;
        // Counting Sundays
        private static readonly bool IS_COUNTING_SUNDAYS = true;

        static void Main(string[] args)
        {
            #region multiples of 3 and 5
            if (IS_MULTIPLES_3_5)
            {
                Console.WriteLine("Sum of all multiples of 3 or 5 below 1000: ");
                ProblemsDoneByHand pdbh = new ProblemsDoneByHand();
                Console.WriteLine(_closeOut);
                Console.WriteLine(pdbh.Answer1());
                Console.WriteLine(_closeOut);
            }
            #endregion

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

            #region 10001st prime
            if (IS_FIND_PRIME_BY_NUMBER)
            {
                Stopwatch sw = new Stopwatch();
                Prime p = new Prime();
                Console.WriteLine("Input Desired Prime Number: ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Selected Prime: " + p.GetPrimeAtNumber(Convert.ToInt32(value)));
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Largest Product in a series
            if (IS_LARGEST_PRODUCT_IN_SERIES)
            {
                Stopwatch sw = new Stopwatch();
                Prime p = new Prime();
                LargestProductSeries lps = new LargestProductSeries();
                sw.Start();
                Console.WriteLine("Answer 8 for long series: " + lps.Answer8());
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Pythagorean Triplet
            if (IS_PYTHAGOREAN_TRIPLET)
            {
                Stopwatch sw = new Stopwatch();
                Palindrome p = new Palindrome();
                PythagoreanTriplet pt = new PythagoreanTriplet();
                Console.WriteLine("Input sum of desired Pythagorean Triplet product:");
                Console.WriteLine(_closeOut);
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Answer: " + pt.Answer9(Convert.ToInt64(value)));
                Console.WriteLine("Values A {0}, B {1}, C {2} ", pt.A, pt.B, pt.C);
                sw.Stop();
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Summation of Primes
            if (IS_SUMMATION_OF_PRIMES)
            {
                Stopwatch sw = new Stopwatch();
                Prime p = new Prime();
                Console.WriteLine("Input max number (primes below it will be summed) : ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Sum of Primes: " + p.GetSumOfPrimes(Convert.ToInt32(value)));
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }

            #endregion

            #region Largest Product in a grid
            if (IS_LARGEST_PRODUCT_IN_GRID)
            {
                Stopwatch sw = new Stopwatch();
                LargestProductSeries lps = new LargestProductSeries();
                sw.Start();
                Console.WriteLine("Answer 11 for product in Grid: " + lps.Answer11());
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Highly divisible trangular number
            if (IS_HIGHLY_DIVISIBLE_TRIANGLE_NUMBER)
            {
                Stopwatch sw = new Stopwatch();
                TriangularNumber tn = new TriangularNumber();
                Console.WriteLine("Input max number (for divisors of triangular number) : ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Number of first triangle with 500 divisors: " + tn.Answer12(Convert.ToInt64(value)));
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Large Sum
            if (IS_LARGE_SUM)
            {
                Stopwatch sw = new Stopwatch();
                LargestSumSeries lss = new LargestSumSeries();
                Console.WriteLine("Answer 13 coming up! : ");
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("First 10 digits of Sum for Answer 13: " + lss.Answer13());
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Longest Collatz sequence
            if (IS_LONGEST_COLLATZ)
            {
                Stopwatch sw = new Stopwatch();
                CollatzSequence cs = new CollatzSequence();
                Console.WriteLine("Input max number: ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("Starting number: " + cs.CollatzLargestUnderInput(Convert.ToInt64(value)) + " Sequence length: " + cs.SequenceLength);
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region LatticePath
            if (IS_LATTICE_PATH)
            {
                Stopwatch sw = new Stopwatch();
                LatticePath lp = new LatticePath();
                Console.WriteLine("Input square grid dimensions: ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("For a {0}x{0} grid there are {1} possible paths. ", Convert.ToInt64(value), lp.LatticePathForSpecifiedGrid(Convert.ToInt64(value)));
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region PowerDigitSum
            if (IS_POWER_DIGIT_SUM)
            {
                Stopwatch sw = new Stopwatch();
                PowerDigitSum pds = new PowerDigitSum();
                Console.WriteLine("Input base number: ");
                string value = Console.ReadLine();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Input power: ");
                string value1 = Console.ReadLine();
                Console.WriteLine(_closeOut);
                sw.Start();
                Console.WriteLine("{0} to the {1} power: ", Convert.ToInt64(value), (Convert.ToInt64(value1)));
                Console.WriteLine("Equals: {0}", pds.Power(Convert.ToInt64(value), Convert.ToInt32(value1)));
                Console.WriteLine(_closeOut);
                Console.WriteLine("Sum of Digits: ");
                Console.WriteLine(pds.BetterSumOfDigits(pds.Power(Convert.ToInt64(value), Convert.ToInt32(value1))));
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Number Letter Counts
            if (IS_NUMBER_LETTER_COUNTS)
            {
                ProblemsDoneByHand pdbh = new ProblemsDoneByHand();
                Console.WriteLine("1- 1000 in words total letters (no spaces or hyphens include ands): ");
                Console.WriteLine(_closeOut);
                Console.WriteLine(pdbh.Answer17());
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Maximum path sum
            if (IS_MAX_PATH_SUM)
            {
                Stopwatch sw = new Stopwatch();
                MaximumPathSum mps = new MaximumPathSum();
                Console.WriteLine("Maximum Path Sum Problem 18: ");
                sw.Start();
                Console.WriteLine("Answer:  " + mps.Problem18());
                sw.Stop();
                Console.WriteLine(_closeOut);
                Console.WriteLine("Duration: " + sw.Elapsed);
                Console.WriteLine(_closeOut);
            }
            #endregion

            #region Counting Sundays
            if (IS_COUNTING_SUNDAYS)
            {
                Stopwatch sw = new Stopwatch();
                DayDateCalculation ddc = new DayDateCalculation();
                Console.WriteLine("Sundays on the first between 1901 - 2000: ");
                sw.Start();
                Console.WriteLine("Answer:  " + ddc.Problem19());
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
