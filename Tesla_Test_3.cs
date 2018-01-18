using System;
using System.Collections.Generic;
using System.Linq;

namespace Testa_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution SolutionA = new Solution();

            int[] Array = new int[] { 3, 7, 2, 5, 4 };

            Console.WriteLine(SolutionA.solution(Array));
        }
    }

    class Solution
    {
        public string solution(int[] A)
        {
            int Sum = A.Sum();

            if (Sum % 3 == 0)
            {
                int stable = Sum / 3;

                List<int> Colors = new List<int>(A);
                Colors.Sort();

                List<int> R = new List<int>();
                List<int> G = new List<int>();
                List<int> B = new List<int>();

                int RSum = 0;
                int GSum = 0;
                int BSum = 0;

                while (Colors.Count > 0)
                {
                    if (RSum < stable && RSum + Colors[Colors.Count - 1] <= stable)
                    {
                        RSum += Colors[Colors.Count - 1];
                        R.Add(Colors[Colors.Count - 1]);
                    }
                    else if (GSum < stable && GSum + Colors[Colors.Count - 1] <= stable)
                    {
                        GSum += Colors[Colors.Count - 1];
                        G.Add(Colors[Colors.Count - 1]);
                    }
                    else if (BSum < stable && BSum + Colors[Colors.Count - 1] <= stable)
                    {
                        BSum += Colors[Colors.Count - 1];
                        B.Add(Colors[Colors.Count - 1]);
                    }

                    Colors.RemoveAt(Colors.Count - 1);
                }

                string tricoloring = "";

                for (int x = 0; x < A.Length; x++)
                {
                    if (R.Contains(A[x]))
                    {
                        tricoloring += "R";
                        R.Remove(A[x]);
                    }
                    if (G.Contains(A[x]))
                    {
                        tricoloring += "G";
                        G.Remove(A[x]);
                    }
                    if (B.Contains(A[x]))
                    {
                        tricoloring += "B";
                        B.Remove(A[x]);
                    }
                }

                return tricoloring;
            }
            else
                return "impossible";
        }
    }
}