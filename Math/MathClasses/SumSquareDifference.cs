using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class SumSquareDifference
    {
        public int SumSquareDifferenceAnswer(int a)
        {
            int answer = 0;
            answer = (squareSum(a)) - (sumSquare(a));

            return answer;
        }

        public int squareSum(int a)
        {
            int squareSum = 0;
            for (int i = 1; i <= a; i++)
            {
                squareSum += i;
            }
            squareSum = squareSum * squareSum;
            return squareSum;
        }

        public int sumSquare(int a)
        {
            int sumSquare = 0;
            int square = 0;
            for (int i = 1; i <= a; i++)
            {
                square = i * i;
                sumSquare += square;
            }
            return sumSquare;
        }
    }
}
