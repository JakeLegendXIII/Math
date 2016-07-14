using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class LatticePath
    {
        public long LatticePathForSpecifiedGrid(long num)
        {
            long answer = 0;
            long[,] grid = new long[num + 1, num + 1];

            for (int i = 0; i < num; i++)
            {
                grid[i, num] = 1;
                grid[num, i] = 1;
            }
            for (long i = num - 1; i >= 0; i--)
            {
                for (long j = num - 1; j >= 0; j--)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                }
            }
            answer = grid[0, 0];

            return answer;
        }
    }
}
