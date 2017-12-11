using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main(string[] args)
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();

        var dm = new DateModifier();
        dm.FirstDate = firstDate;
        dm.SecondDate = secondDate;

        Console.WriteLine(dm.DateDiff(firstDate,secondDate));


    }
}

