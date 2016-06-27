using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.MathClasses
{
    class Palindrome
    {
        public int Factor { get; set; }
        public int Factor1 { get; set; }

        // Solution Methods
        public int LargestPalindromeThreeDigitsRecursive()
        {
            int result = 0;
            for (int x = 100; x <= 999; x++)
            {
                for (int y = 100; y <= 999; y++)
                {
                    int num = x * y;
                    if (num.ToString() == ReverseString(num.ToString()))
                    {
                        if (result < num)
                        {
                            result = num;
                        }
                    }
                }
            }
            return result;
        }

        public int LargestPalindromeThreeDigitsQuicker()
        {
            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                palin = MakePalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        Factor = factors[0];
                        Factor1 = factors[1];
                        break;
                    }
                }
            }
            return palin;
        }

        // Helper Methods
        public string ReverseString(string val)
        {
            char[] arr = val.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }

        private int MakePalindrome(int firstHalf)
        {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }
    }
}
