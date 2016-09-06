using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class QuadraticPrimes
    {
        public int AMax { get; set; }
        public int BMax { get; set; }
        public int NMax { get; set; }
        int[] primes;

        public int Problem27()
        {
            int answer = 0;
            int aMax = 0, bMax = 0, nMax = 0;
            primes = ESieve(87400);

            for (int a = -1000; a <= 1000; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {

                    int n = 0;
                    while (isPrime(System.Math.Abs(n * n + a * n + b)))
                    {
                        n++;
                    }

                    if (n > nMax)
                    {
                        aMax = a;
                        bMax = b;
                        nMax = n;
                    }
                }
            }
            AMax = aMax;
            BMax = bMax;
            NMax = nMax;
            answer = nMax;
            return answer;
        }

        public int[] ESieve(int upperLimit)
        {

            int sieveBound = (int) (upperLimit - 1) / 2;
            int upperSqrt = ((int) System.Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int) (upperLimit / (System.Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);
            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }

        private bool isPrime(int testNumber)
        {
            int i = 0;
            while (primes[i] <= testNumber)
            {
                if (primes[i] == testNumber)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}
