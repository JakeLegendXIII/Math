using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class LexicographicPermutations
    {
        int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public string Answer24()
        {
            int N = perm.Length;
            string answer = "";
            int remain = 1000000 - 1;

            List<int> numbers = new List<int>();
            for (int i = 0; i < N; i++)
            {
                numbers.Add(i);
            }


            for (int i = 1; i < N; i++)
            {
                int j = remain / Factor(N - i);
                remain = remain % Factor(N - i);

                answer = answer + numbers[j];
                numbers.RemoveAt(j);

                if (remain == 0)
                {
                    break;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                answer = answer + numbers[i];
            }

            return answer;
        }

        private int Factor(int v)
        {
            if (v < 0)
            {
                return 0;
            }

            int p = 1;
            for (int j = 1; j <= v; j++)
            {
                p *= j;
            }
            return p;
        }
    }
}
