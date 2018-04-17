using System.Collections.Generic;
using System.Linq;

namespace P06StrategyPattern
{
    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var result = x.Name.Length.CompareTo(y.Name.Length);

            if(result == 0)
            {
                result = x.Name.ToLower().First().CompareTo(y.Name.ToLower().First());
            }

            return result;
        }
    }
}
