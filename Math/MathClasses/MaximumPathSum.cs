using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class MaximumPathSum
    {
        public long  Problem18()
        {
            long answer = 0;
            answer = BruteForce();
            return answer;
        }


        // Bruteforce method for now, better option coming later
        public long BruteForce()
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Problem18.txt";
            int[,] inputTriangle = readInput(filename);

            int posSolutions = (int) System.Math.Pow(2, inputTriangle.GetLength(0) - 1);
            int largestSum = 0;
            int tempSum, index;

            for (int i = 0; i <= posSolutions; i++)
            {
                tempSum = inputTriangle[0, 0];
                index = 0;
                for (int j = 0; j < inputTriangle.GetLength(0) - 1; j++)
                {
                    index = index + (i >> j & 1);
                    tempSum += inputTriangle[j + 1, index];
                }

                if (tempSum > largestSum)
                {
                    largestSum = tempSum;
                }
            }
            return largestSum;
        }

        private int[,] readInput(string filename)
        {
            string line;
            string[] linePieces;
            int lines = 0;

            StreamReader r = new StreamReader(filename);
            while ((line = r.ReadLine()) != null)
            {
                lines++;
            }

            int[,] inputTriangle = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputTriangle[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }

            r.Close();

            return inputTriangle;
        }
    }
}
