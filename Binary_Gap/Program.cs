using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Gap
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int.TryParse(Console.ReadLine(), out input);
            Console.WriteLine("Answer: {0}", solution(input));
        }

        static int solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            bool inGap = false;
            long length = 0, largest = 0;


            foreach (var item in binary.ToArray())
            {
                long intItem = (long)Char.GetNumericValue(item);

                if (intItem == 0 && inGap) length++;
                else if (intItem == 1 && !inGap) inGap = true;
                else if (intItem == 1 && inGap)
                {
                    if (length > largest) largest = length;
                    length = 0;
                }
            }

            return (int)largest;
        }
    }
}
