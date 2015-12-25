using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perm_Element_Missing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 2, 3, 1, 5 }; // Example input
            Console.WriteLine("Missing element is: {0}", Solution(input));
        }

        static int Solution(int[] A)
        {
            if (A.Length <= 0) return 1;

            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != (i + 1)) return i + 1;
            }

            return A.Length + 1;
        }
    }
}
