using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class SmallestMultiple
    {
        public int SmallestMultipleByRange(int num)
        {
            int answer = 1;
            int[] nums = Enumerable.Range(1, num).ToArray();
            for (int i =0; i < nums.Length; i++)
            {
                answer = LCM(answer, nums[i]);
            }

            return answer;
        }

        private int LCM(int val1, int val2)
        {
            val1 = checked((val1 / GCD(val1, val2)));

            return checked((val1 * val2));
        }

        private int GCD(int val1, int val2)
        {
            int gcd = 1;

            if (val1 == 0 || val2 == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (val1 == val2) { return val1; }
            if (val1 > val2 && val1 % val2 ==0) { return val2; }
            if (val2 > val1 && val2 % val1 == 0) { return val1; }
            while (val2 != 0)
            {
                gcd = val2;
                val2 = val1 % val2;
                val1 = gcd;
            }

            return gcd;
        }
    }
}
