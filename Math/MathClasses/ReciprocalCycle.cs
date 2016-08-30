using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class ReciprocalCycle
    {
        public int SequenceLength { get; set; }

        public int Answer26(int maxSize)
        {
            int sequenceLength = 0;
            int answer = 0;

            for (int i = 1000; i > 1; i--)
            {
                if (sequenceLength >= i)
                {
                    break;
                }

                int[] foundRemainders = new int[i];
                int value = 1;
                int position = 0;

                while (foundRemainders[value] == 0 && value != 0)
                {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength)
                {
                    answer = i;
                    sequenceLength = position - foundRemainders[value];
                }
            }
            SequenceLength = sequenceLength;
            return answer;
        }
    }
}
