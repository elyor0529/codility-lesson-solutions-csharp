using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Max_Counters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] input = new int[] { 3, 4, 4, 6, 1, 4, 4 };

            Console.Write("Counter: [ ");
            foreach (var item in Solution(n, input))
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine(" ]");
        }

        static int[] Solution(int N, int[] A)
        {
            if (A.Length <= 0) return null;

            int[] counter = new int[N];
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == (N + 1))
                {
                    for (int j = 0; j < counter.Length; j++) counter[j] = max;
                }
                else if ((A[i] <= N) && (A[i] >= 1))
                {
                    counter[A[i] - 1]++;
                    if (counter[A[i] - 1] > max) max = counter[A[i] - 1];
                }

            }

            return counter;
        }
    }
}
