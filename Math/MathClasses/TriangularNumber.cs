using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class TriangularNumber
    {
        public long Answer12(long num)
        {
            int answer = 0;
            int i = 1;

            while (NumberOfDivisors(answer) < num)
            {
                answer += i;
                i++;
            }
            return answer;
        }

        private int NumberOfDivisors(int number)
        {
            int nod = 0;
            int sqrt = (int) System.Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                }
            }
            //Correction if the number is a perfect square
            if (sqrt * sqrt == number)
            {
                nod--;
            }

            return nod;
        }
    }
}
