using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class FactorialSum
    {
        public BigInteger Factor { get; set; }

        public BigInteger FactorialDigitSum(BigInteger num)
        {
            BigInteger answer = 1;
            BigInteger temp = num;
            for (int i = 1; i <= num; i++)
            {
                answer *= i;
            }
            Factor = answer;
            answer = SumOfDigits(answer);
            return answer;
        }

        public BigInteger SumOfDigits(BigInteger num)
        {
            BigInteger answer = 0;
            string number = num.ToString();
            char[] digitArray = number.ToCharArray();
            for (int i = 0; i < digitArray.Length; i++)
            {
                answer += long.Parse(digitArray[i].ToString());
            }
            return answer;
        }

        public int SumOfFactorialsIsNumber()
        {
            int result = 0;
            for (int i = 10; i < 2540161; i++)
            {
                int sumOfFacts = 0;
                int number = i;
                while (number > 0)
                {
                    int d = number % 10;
                    number /= 10;
                    sumOfFacts += SimpleFactorial(d);
                }

                if (sumOfFacts == i)
                {
                    result += i;
                }
            }

            return result;
        }
        private int SimpleFactorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            int y = x;
            for (int i = 1; i < x; i++)
            {
                y *= i;
            }
            return y;
        }
    }
}
