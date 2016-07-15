using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class PowerDigitSum
    {      
        public BigInteger Power(long num, int power)
        {
            BigInteger answer = 0;
            answer = BigInteger.Pow(num, power);
            return answer;
        }

        // First Attempt
        public BigInteger SumOfDigits(BigInteger num)
        {
            BigInteger answer = 0;
            string number = num.ToString();
            char[] digitArray = number.ToCharArray();
            for(int i = 0; i < digitArray.Length; i++)
            {
                answer += BigInteger.Parse(digitArray[i].ToString());
            }
            return answer;
        }

        // Better Attempt
        public int BetterSumOfDigits(BigInteger num)
        {
            int answer = 0;
            while (num > 0)
            {
                answer += (int) (num % 10);
                num /= 10;
            }
            return answer;
        }
    }
}
