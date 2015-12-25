using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd_Occurences_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 9, 3, 9, 3, 9, 7, 9 }; // Example input
            Console.WriteLine("Odd occurence is: {0}", Solution(input));
        }

        static int Solution(int[] A)
        {
            if (A.Length <= 0) return -1;

            int odd = 0;
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (i == A.Length - 1) odd = A[A.Length - 1];
                else if (A[i] != A[i + 1]) odd = A[i];
                else i++;
            }

            return odd;
        }
    }
}
