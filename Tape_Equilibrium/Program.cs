using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tape_Equilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 3, 1, 2, 4, 3 }; // Example input
            Console.WriteLine("Answer: {0}", Solution(input));
        }

        static int Solution(int[] A)
        {
            if (A.Length <= 0) return -1;

            long leftSum = A[0], rightSum = A.Sum() - A[0];
            int minDifference = int.MaxValue;

            for (int i = 1; i < A.Length; i++)
            {
                int difference = (int) Math.Abs(leftSum - rightSum);
                if (difference < minDifference) minDifference = difference;

                leftSum += A[i];
                rightSum -= A[i];
            }

            return minDifference;
        }
    }
}
