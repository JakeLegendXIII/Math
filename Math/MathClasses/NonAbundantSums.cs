using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class NonAbundantSums
    {
        public long Answer23(int limit)
        {
            long answer = 0;
            List<int> abundent = new List<int>();
            int[] primelist = ESieve((int) System.Math.Sqrt(limit));
            // Find all abundant numbers
            for (int i = 2; i <= limit; i++)
            {
                if (sumOfFactorsPrime(i, primelist) > i)
                {
                    abundent.Add(i);
                }
            }
            // Make all the sums of two abundant numbers
            bool[] canBeWrittenasAbundent = new bool[limit + 1];
            for (int i = 0; i < abundent.Count; i++)
            {
                for (int j = i; j < abundent.Count; j++)
                {
                    if (abundent[i] + abundent[j] <= limit)
                    {
                        canBeWrittenasAbundent[abundent[i] + abundent[j]] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //Sum the numbers which are not sums of two abundant numbers
            for (int i = 1; i <= limit; i++)
            {
                if (!canBeWrittenasAbundent[i])
                {
                    answer += i;
                }
            }
            return answer;
        }

        private int sumOfFactorsPrime(int num, int[] primelist)
        {
            int n = num;
            int sum = 1;
            int p = primelist[0];
            int j;
            int i = 0;

            while (p * p <= n && n > 1 && i < primelist.Length)
            {
                p = primelist[i];
                i++;
                if (n % p == 0)
                {
                    j = p * p;
                    n = n / p;
                    while (n % p == 0)
                    {
                        j = j * p;
                        n = n / p;
                    }
                    sum = sum * (j - 1) / (p - 1);
                }
            }
            //A prime factor larger than the square root remains, so add that
            if (n > 1)
            {
                sum *= n + 1;
            }
            return sum - num;
        }

        private int[] ESieve(int v)
        {
            int sieveBound = (int) (v - 1) / 2;
            int upperSqrt = ((int) System.Math.Sqrt(v) - 1) / 2;

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
            List<int> numbers = new List<int>((int) (v / (System.Math.Log(v) - 1.08366)));
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
    }
}
