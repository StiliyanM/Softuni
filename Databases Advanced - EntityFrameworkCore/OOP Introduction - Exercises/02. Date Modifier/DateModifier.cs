using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateModifier
{
    public string FirstDate { get; set; }
    public string SecondDate { get; set; }

    public int DateDiff(string firstDate, string secondDate)
    {
        var date1 = DateTime.Parse(firstDate);
        var date2 = DateTime.Parse(secondDate);

        var diff = date1.Subtract(date2);

        return Math.Abs(diff.Days);
    }
}

