using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    public class Fibonacci
    {
        public int Number { get; set; }

        public int FibonacciSimple(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public double SumOfEvenFibonacciTerms(int a)
        {
            double sum = 0;
            for (int i = 0; i < 34; i++)
            {
                //Sum up only terms divisble by 2, AKA even numbers 
                if (FibonacciSimple(i) % 2 == 0)
                {
                    Console.WriteLine(FibonacciSimple(i));
                    sum += FibonacciSimple(i);
                }         
            }
            Console.WriteLine("The sum of the even Fibonnaci numbers: " + sum);
            return sum;
        }

        public long FibonacciDigitCount(int n)
        {
            long answer = 0;
            BigInteger a = 0;
            BigInteger b = 1;
            int count = 0;
            int index = 0;
            while (count < n)
            {
                BigInteger temp = a;
                a = b;
                b = temp + b;
                string characters = a.ToString();
                count = characters.Length;
                index++;
            }
            answer = index;
            return answer;
        }
    }
}
