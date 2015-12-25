using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Missing_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 3, 6, 4, 1, 2 }; // Example values
            // int[] input = new int[] { -1, 5, 4, 3, 2, 1 };
            // int[] input = new int[] { -1, 1, 2, 3, 4, 5 };
            // int[] input = new int[] { 0, 10, 1, 4, 7, 2, 5, 8, 3, 6, 9, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // int[] input = new int[] { 11 };
            // int[] input = new int[] { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Missing integer: {0}", Solution(input));
        }

        static int Solution(int[] A)
        {
            if (A.Length <= 0) return -1;

            Array.Sort(A);
            A = A.Where(i => (i >= 0)).Distinct().ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != (i + 1)) return i + 1;
            }

            return A.Length + 1;
        }
    }
}
