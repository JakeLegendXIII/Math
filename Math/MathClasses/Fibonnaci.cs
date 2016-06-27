using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    public class Fibonnaci
    {
        public int Number { get; set; }

        public int Fibonacci(int n)
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

        public double SumOfEvenFibonnaciTerms(int a)
        {
            double sum = 0;
            for (int i = 0; i < 34; i++)
            {
                //Sum up only terms divisble by 2, AKA even numbers 
                if (Fibonacci(i) % 2 == 0)
                {
                    Console.WriteLine(Fibonacci(i));
                    sum += Fibonacci(i);
                }         
            }
            Console.WriteLine("The sum of the even Fibonnaci numbers: " + sum);
            return sum;
        }
    }
}
