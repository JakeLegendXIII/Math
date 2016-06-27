using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class LargestPrimeFactor
    {
        public long LargestPrimeFactorSlow(long value)
        {
            long largestFact = 0;
            long[] factors = new long[2];
           
            for (long i = 2; i * i < value; i++)
            {
                if (value % i == 0)
                { // It is a divisor
                    factors[0] = i;
                    factors[1] = value / i;

                    for (int k = 0; k < 2; k++)
                    {
                        bool isPrime = true;
                        for (long j = 2; j * j < factors[k]; j++)
                        {
                            if (factors[k] % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime && factors[k] > largestFact)
                        {
                            largestFact = factors[k];
                        }
                    }
                }
            }
            return largestFact;
        }

        public long LargestPrimeFactorFaster(long value)
        {
            long largestFact = 0;
            int counter = 2;
            while (counter * counter <= value)
            {
                if (value % counter == 0)
                {
                    value = value / counter;
                    largestFact = counter;
                }
                else {
                    //counter++;
                    counter = (counter == 2) ? 3 : counter + 2; ;
                }
            }
            if (value > largestFact)
            { // the remainder is a prime number
                largestFact = value;
            }
            return largestFact;
        }
    }
}
