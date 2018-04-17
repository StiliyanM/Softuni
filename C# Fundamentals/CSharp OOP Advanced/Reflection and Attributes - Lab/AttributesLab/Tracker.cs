using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);

        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var methodInfo in methods)
        {
            if(methodInfo.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
            {
                var attributes = methodInfo.GetCustomAttributes(false);

                foreach (SoftUniAttribute a in attributes)
                {
                    Console.WriteLine($"{methodInfo.Name} is written by {a.Name}");
                }
            }
        }
    }
}
