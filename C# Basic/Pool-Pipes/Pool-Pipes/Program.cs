using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            double LitresFull = (P1 + P2) * H;
            double PercentFull = LitresFull / V * 100;
            double P1Percent = P1 * H / LitresFull * 99;
            double P2Percent = P2 * H / LitresFull * 99;

            Convert.ToInt32(P1Percent);
            Convert.ToInt32(P2Percent);
            Convert.ToInt32(PercentFull);

            if (PercentFull < 100)
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                                  PercentFull, P1Percent, P2Percent );
            else
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                                     H, LitresFull - V);
        }
    }
}
