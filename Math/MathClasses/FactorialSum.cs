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
    }
}
