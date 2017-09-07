using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Program
    {
        class Arm
        {
            public uint EnergyConsumption { get; set; }
            public int ArmReachDistance { get; set; }
            public int FingersCount { get; set; }
        }

        class Leg
        {
            public uint EnergyConsumption { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }
        }

        class Torso
        {
            public uint EnergyConsumption { get; set; }
            public double ProcessorSizeInCentimeters { get; set; }
            public string HousingMaterial { get; set; }
        }

        class Head
        {
            public uint EnergyConsumption { get; set; }
            public int Iq { get; set; }
            public string SkinMaterial { get; set; }
        }

        static void Main(string[] args)
        {
            ulong maxEnergyCapacity = ulong.Parse(Console.ReadLine());
            uint headMinEnergy = uint.MaxValue;
            uint torsoMinEnergy = uint.MaxValue;
            uint armMinEnergy = uint.MaxValue;
            uint legMinEnergy = uint.MaxValue;


            var arms = new List<Arm>();
            var legs = new List<Leg>();
            var torso = new Torso();
            var head = new Head();

            while (true)
            {
                var tokens = Console.ReadLine().Split().ToArray();

                if (tokens[0] == "Assemble!")
                {
                    break;
                }


                string typeOfComponent = tokens[0];

                if (typeOfComponent == "Arm")
                {
                    uint energyConsumption = uint.Parse(tokens[1]);
                    var armReachDistance = int.Parse(tokens[2]);
                    var fingersCount = int.Parse(tokens[3]);

                    if (energyConsumption < armMinEnergy)
                    {
                        if (arms.Count == 2)
                        {                            
                                arms.RemoveAt(0);
                            
                        }
                        Arm arm = new Arm();
                        arm = AddArm(typeOfComponent, energyConsumption, armReachDistance, fingersCount);
                        arms.Add(arm);
                        armMinEnergy = energyConsumption;

                    }
                }
                else if (typeOfComponent == "Leg")
                {
                    uint energyConsumption = uint.Parse(tokens[1]);
                    var strength = int.Parse(tokens[2]);
                    var speed = int.Parse(tokens[3]);

                    if (energyConsumption < legMinEnergy)
                    {
                        if (legs.Count == 2)
                        {
                                legs.RemoveAt(0);
                            
                        }

                        Leg leg = new Leg();
                        leg = AddLeg(typeOfComponent, energyConsumption, strength, speed);
                        legs.Add(leg);

                        legMinEnergy = energyConsumption;
                    }
                }
                else if (typeOfComponent == "Torso")
                {
                    uint energyConsumption = uint.Parse(tokens[1]);
                    var processorSize = double.Parse(tokens[2]);
                    var housingMaterial = tokens[3];
                    if (energyConsumption < torsoMinEnergy)
                    {
                        torso = new Torso();
                        torso = AddTorso(typeOfComponent, energyConsumption, processorSize, housingMaterial);
                        torsoMinEnergy = energyConsumption;
                    }
                }
                else if (typeOfComponent == "Head")
                {
                    uint energyConsumption = uint.Parse(tokens[1]);
                    var iq = int.Parse(tokens[2]);
                    var skinMaterial = tokens[3];
                    if (energyConsumption < headMinEnergy)
                    {
                        head = new Head();
                        head = AddHead(typeOfComponent, energyConsumption, iq, skinMaterial);
                        headMinEnergy = energyConsumption;
                    }
                }
            }

            ulong totalEnergyConsumption = head.EnergyConsumption + torso.EnergyConsumption;

            foreach (var arm in arms)
            {
                totalEnergyConsumption += arm.EnergyConsumption;
            }

            foreach (var leg in legs)
            {
                totalEnergyConsumption += leg.EnergyConsumption;
            }

            if (maxEnergyCapacity < totalEnergyConsumption)
            {
                Console.WriteLine($"We need more power!");
            }
            else if (head.EnergyConsumption == 0 || torso.EnergyConsumption == 0 || arms.Count < 2 || legs.Count < 2)
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                PrintJarvis(head, torso, arms, legs);
            }
        }

        private static void PrintJarvis(Head head, Torso torso, List<Arm> arms, List<Leg> legs)
        {
            Console.WriteLine("Jarvis:");
            Console.WriteLine($"#Head:");
            Console.WriteLine($"###Energy consumption: {head.EnergyConsumption}");
            Console.WriteLine($"###IQ: {head.Iq}");
            Console.WriteLine($"###Skin material: {head.SkinMaterial}");

            Console.WriteLine($"#Torso:");
            Console.WriteLine($"###Energy consumption: {torso.EnergyConsumption}");
            Console.WriteLine($"###Processor size: {torso.ProcessorSizeInCentimeters:f1}");
            Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");

            foreach (var arm in arms.OrderBy(x => x.EnergyConsumption))
            {
                Console.WriteLine($"#Arm:");
                Console.WriteLine($"###Energy consumption: {arm.EnergyConsumption}");
                Console.WriteLine($"###Reach: {arm.ArmReachDistance}");
                Console.WriteLine($"###Fingers: {arm.FingersCount}");

            }

            foreach (var leg in legs.OrderBy(x => x.EnergyConsumption))
            {
                Console.WriteLine($"#Leg:");
                Console.WriteLine($"###Energy consumption: {leg.EnergyConsumption}");
                Console.WriteLine($"###Strength: {leg.Strength}");
                Console.WriteLine($"###Speed: {leg.Speed}");
            }
        }

        private static Head AddHead(string typeOfComponent, uint energyConsumption, int iq, string skinMaterial)
        {
            Head head = new Head()
            {
                EnergyConsumption = energyConsumption,
                Iq = iq,
                SkinMaterial = skinMaterial
            };
            return head;
        }

        private static Torso AddTorso(string typeOfComponent, uint energyConsumption, double processorSize, string housingMaterial)
        {
            Torso torso = new Torso()
            {
                EnergyConsumption = energyConsumption,
                ProcessorSizeInCentimeters = processorSize,
                HousingMaterial = housingMaterial
            };
            return torso;
        }

        private static Leg AddLeg(string typeOfComponent, uint energyConsumption, int strength, int speed)
        {
            Leg leg = new Leg()
            {
                EnergyConsumption = energyConsumption,
                Strength = strength,
                Speed = speed
            };
            return leg;
        }

        private static Arm AddArm(string typeOfComponent, uint energyConsumption, int armReachDistance, int fingersCount)
        {
            Arm arm = new Arm()
            {
                EnergyConsumption = energyConsumption,
                ArmReachDistance = armReachDistance,
                FingersCount = fingersCount
            };
            return arm;
        }
    }
}
