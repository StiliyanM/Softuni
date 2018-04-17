using System;
using System.Collections.Generic;
using System.Linq;

namespace P04TrafficLights
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var lights = Console.ReadLine().Split()
                .Select(Enum.Parse<TrafficLight>)
                .ToList();

            var shiftCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < shiftCount; i++)
            {
                Shift(lights);
                Print(lights);
            }
        }

        private static void Print(List<TrafficLight> lights)
        {
            Console.WriteLine(string.Join(" ",lights));
        }

        private static void Shift(List<TrafficLight> lights)
        {
            for (int i = 0; i < lights.Count; i++)
            {
                lights[i] = ChangeLight(lights[i]);
            }        
        }

        private static TrafficLight ChangeLight(TrafficLight trafficLight)
        {
            var nextValue = ((int)trafficLight + 1) % 3;

            var nextLight = (TrafficLight)nextValue;
            return nextLight;
        }
    }
}
