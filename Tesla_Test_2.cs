using System;
using System.Collections.Generic;
using System.Linq;

namespace Testa_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution SolutionA = new Solution();

            int[] Array = new int[] { -5, -5, -5, -42, 6, 12 };

            Console.WriteLine(SolutionA.solution(Array));
        }
    }

    class Solution
    {
        public int solution(int[] T)
        {
            List<int> YearDays = new List<int>(T);

            YearDays.Sort();

            int WarmestWinterDayTemperature = YearDays[0];

            for (int x = 1; x < T.Length ; x++)
            {
                List<int> RestOfDays = new List<int> ();

                for (int y = x; y < T.Length; y++)
                    RestOfDays.Add(T[y]);

                RestOfDays.Sort();
                int ColdestSummerDayTemperature = RestOfDays[0];

                if (T[x - 1] < T[x] && WarmestWinterDayTemperature < ColdestSummerDayTemperature)
                    return x;
                else if (T[x - 1] > WarmestWinterDayTemperature)
                    WarmestWinterDayTemperature = T[x - 1];
            }

            return T.Length;
        }
    }
}