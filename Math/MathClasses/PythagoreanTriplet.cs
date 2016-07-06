using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class PythagoreanTriplet
    {
        public long A { get; set; }
        public long B { get; set; }
        public long C { get; set; }


        public long Answer9(long sum)
        {
            long answer = 0;
            long a;
            for (a = 1; a < sum/3; a++)
            {
                long b;
                for (b = a + 1; b <= sum/2; b++)
                {
                    long c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        answer = a * b * c;
                        A = a; 
                        B = b;
                        C = c;
                        break;
                    }                   
                }
            }
            return answer;
        }
    }
}
