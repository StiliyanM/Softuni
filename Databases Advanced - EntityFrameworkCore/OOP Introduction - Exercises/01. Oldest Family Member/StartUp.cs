using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split();

            var name = args[0];
            var age = int.Parse(args[1]);

            var person = new Person(name, age);

            family.AddMember(person);
        }

        Console.WriteLine(family.GetOldestMember());

        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

    }
}

