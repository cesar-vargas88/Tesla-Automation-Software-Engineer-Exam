using System;
using System.Collections.Generic;
using System.Linq;

namespace Testa_Test_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution SolutionA = new Solution();

            int[] Array = new int[] {-2, -3};

            Console.WriteLine(SolutionA.solution(Array));
        }
    }

    // you can also use imports, for example:
    // import java.util.*;

    // you can write to stdout for debugging purposes, e.g.
    // System.out.println("this is a debug message");

    class Solution
    {
        public int solution(int[] A)
        {
            List<int> lst = new List<int> (A);
            lst.Sort();

            while(lst[0] < 1)
            {
                lst.Remove(lst[0]);

                if (lst.Count == 0)
                    return 1;
            }     

            for (int x = 1; x < lst.Count; x++)
            {
                if (lst.IndexOf(x) < 0)
                    return x;
            }

            return lst[lst.Count - 1] + 1;
        }
    }
}