using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace From_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, d;

            Console.Write("Value of X: ");
            int.TryParse(Console.ReadLine(), out x);

            Console.Write("Value of Y: ");
            int.TryParse(Console.ReadLine(), out y);

            Console.Write("Value of D: ");
            int.TryParse(Console.ReadLine(), out d);

            Console.WriteLine("Number of steps: {0}", Solution(x,y,d));
        }

        static int Solution(int X, int Y, int D)
        {
            if ((Y < X) || (D == 0)) return -1;

            double steps = ((double)Y - (double)X) / (double)D;
            return (int) Math.Ceiling(steps);
        }
    }
}
