using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class ProblemsDoneByHand
    {
        public long Answer1()
        {
            long answer = 0;
            //Formula 1/2n(n+1)
            // Subtract multiples of fifteen since they are shared
            double three = 3 * (.5 * 333 *(333 + 1));
            double five = 5 * (.5 * 199 * (199 + 1));
            double fifteen = 15* (.5 * 66 * (66 + 1));
            double result = (three + five) - fifteen;
            answer = Convert.ToInt64(result);
            return answer;
        }

        public long Answer17()
        {
            long answer = 0;
            // Count uniques then apply patterns
            int num1_9 = 3 + 3 + 5 + 4 + 4 + 3 + 5 + 5 + 4;
            int num10_19 = 3 + 6 + 6 + 8 + 8 + 7 + 7 + 9 + 8 + 8;
            int num20_99 = 10 * (6 + 6 + 5 + 5 + 5 + 7 + 6 + 6) + 8 * 36;
            int num100_999 = 3600 + 7686 + 63 + 8910;
            int num1000 = 11;

            answer = num1_9 + num10_19 + num20_99 + num100_999 + num1000;
            return answer;
        }
    }
}
