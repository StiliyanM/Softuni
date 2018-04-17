using System;

namespace P05DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dm = new DateModifier();
            dm.FirstDate = firstDate;
            dm.SecondDate = secondDate;

            Console.WriteLine(dm.DateDiff(firstDate, secondDate));

        }
    }
}
