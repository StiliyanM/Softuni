using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());
            var bonus = 0.0;

            var isEven = score % 2 == 0;

            var isLastNumber5 = score % 5 == 0 && score % 10 != 0;
            if(score > 1000)
            {
                bonus = score * 0.1;
            }
            else if(score > 100)
            {
                bonus = score * 0.2;
            }
            else if(score <= 100)
            {
                bonus += 5;
            }

            if (isEven)
            {
                bonus += 1;
            }

            if (isLastNumber5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(score + bonus);
        }
    }
}
