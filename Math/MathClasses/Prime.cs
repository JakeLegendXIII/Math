using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class Prime
    {
        public int GetPrimeAtNumber(int num)
        {
            int answer = 1;
            int count = 0;
            int n = 1;
            for (var i = 1; ; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                    if (count == num)
                    {
                        answer = i;
                        break;
                    }
                        
                }
            }
            return answer;
        }
        //Problem 10
        public long GetSumOfPrimes(int num)
        {
            long answer = 0;
            for (var i = 1; i <= num; i++)
            {
                if(IsPrime(i))
                {
                    answer += i;
                }
            }
            return answer;
        }

        public static bool IsPrime(int p)
        {
            if ((p & 1) == 0)
            {
                if (p == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= p; i += 2)
            {
                if ((p % i) == 0)
                {
                    return false;
                }
            }
            return p != 1;
        }
    }
}
