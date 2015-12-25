using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frog_River_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] input = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }; // Example values
            Console.WriteLine("Shortest time: {0}", Solution(x, input));
        }

        static int Solution(int X, int[] A)
        {
            if (A.Length <= 0) return -1;

            bool[] leaves = new bool[X];
            for (int i = 0; i < A.Length; i++)
            {
                if (leaves.Length > (A[i] - 1)) leaves[A[i] - 1] = true;
                if (Array.IndexOf(leaves, false) < 0) return i;
            }

            return -1;
        }
    }
}
