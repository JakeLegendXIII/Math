using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class AmicableNumbers
    {
        public long Simple(long num)
        {
            int sumAmicible = 0;
            int factorsi, factorsj;

            for (int i = 2; i <= num; i++)
            {
                factorsi = SumOfFactors(i);
                if (factorsi > i && factorsi <= num)
                {
                    factorsj = SumOfFactors(factorsi);
                    if (factorsj == i)
                    {
                        sumAmicible += i + factorsi;
                    }
                }
            }
            return sumAmicible;
        }

        private int SumOfFactors(int num)
        {
            int sqrtOfNumber = (int) System.Math.Sqrt(num);
            int sum = 1;
            //If the number is a perfect square
            //Count the squareroot once in the sum of factors
            if (num == sqrtOfNumber * sqrtOfNumber)
            {
                sum += sqrtOfNumber;
                sqrtOfNumber--;
            }

            for (int i = 2; i <= sqrtOfNumber; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i + (num / i);
                }
            }

            return sum;
        }
    }
}
