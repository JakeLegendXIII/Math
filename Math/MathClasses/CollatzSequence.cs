using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class CollatzSequence
    {
        public long SequenceLength { get; set; }

        public long CollatzLargestUnderInput(long num)
        {
            long answer = 0;
            long sequenceLength = 0;
            long startingNumber = 0;
            long sequence;

            for (int i = 2; i <= num; i++)
            {
                int length = 1;
                sequence = i;
                while (sequence != 1)
                {
                    if ((sequence % 2) == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else {
                        sequence = sequence * 3 + 1;
                    }
                    length++;
                }
                //Check if sequence is the best solution
                if (length > sequenceLength)
                {
                    sequenceLength = length;
                    startingNumber = i;
                }
            }
            answer = startingNumber;
            SequenceLength = sequenceLength;

            return answer;
        }
    }
}
