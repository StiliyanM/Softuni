using System;
using System.Linq;
using System.Reflection;


class StartUp
{
    static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        //Console.WriteLine(fields.Count());

        try
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(height, width, length);

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.GetVolume():f2}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}

