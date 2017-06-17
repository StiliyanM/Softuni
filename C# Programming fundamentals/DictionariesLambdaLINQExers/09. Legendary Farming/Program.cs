using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new SortedDictionary<string, int>()
            {
                {"shards", 0 }, {"fragments", 0 }, {"motes" , 0 }
            };
            var junkMaterials = new SortedDictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;
                        if(keyMaterials[material] >= 250)
                        {
                            GetOutput(keyMaterials, junkMaterials,material);
                            return;
                        }
                    }
                    else
                    {
                        if(!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = quantity;
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }

                }
            }
        }

        private static void GetOutput(SortedDictionary<string, int> keyMaterials, SortedDictionary<string, int> junkMaterials,string material)
        {
            if(material== "shards")
                Console.WriteLine("Shadowmourne obtained!");
            else if(material == "fragments")
                Console.WriteLine("Valanyr obtained!");
            else if(material == "motes")
                Console.WriteLine("Dragonwrath obtained!");

            keyMaterials[material] -= 250;

            var OrderedKey = keyMaterials.OrderByDescending(x => x.Value);

            foreach (var item in OrderedKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item1 in junkMaterials)
            {
                Console.WriteLine($"{item1.Key}: {item1.Value}");
            }
        }
    }
}
