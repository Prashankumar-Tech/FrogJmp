using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10, 41, 30));
        }

        public static int Solution(int X, int Y, int D)
        {
            return ((Y - X) % D == 0) ? (Y - X) / D : ((Y - X) / D) + 1;
        }
    }
}
