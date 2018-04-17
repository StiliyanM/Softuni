using System;

namespace P03Scale
{
    class StartUp
    {
        static void Main()
        {
            var scale = new Scale<string>("az", "ti");

            Console.WriteLine(scale.GetHeavier());
        }
    }
}
