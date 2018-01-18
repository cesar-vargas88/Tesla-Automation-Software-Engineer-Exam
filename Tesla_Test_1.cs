using System;
using System.Collections.Generic;
using System.Linq;

namespace Testa_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution SolutionA = new Solution();

            int[] Array = new int[] { 1, 1, 0, 1, 0, 0 };

            Console.WriteLine(SolutionA.solution(Array));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] == A[i + 1])
                    result = result + 1;
            }

            int r = 0;

            //for (int i = 0; i < n ; i++)
            for (int i = 1; i < n - 1; i++)
            {
                int count = 0;

                if (i > 0)
                {
                    if (A[i - 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }

                if (i < n - 1)
                {
                    if (A[i + 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }

                r = Math.Max(r, count);
            }

            return result + r;
        }
    }
}