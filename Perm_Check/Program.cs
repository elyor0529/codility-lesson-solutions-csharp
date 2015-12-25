using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perm_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] input = new int[] { 4, 1, 3, 2 }; // Example values
            int[] input = new int[] { 4, 1, 3 }; // Example values
            Console.WriteLine("Shortest time: {0}", Solution(input));
        }

        static int Solution(int[] A)
        {
            if (A.Length <= 0) return 0;

            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != (i + 1)) return 0;
            }

            return 1;
        }
    }
}
