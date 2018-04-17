using System;
using System.Collections.Generic;
using System.Text;
public class GameController
{
    private Army army;
    private WareHouse warehouse;

    public GameController(Army army, WareHouse warehouse)
    {
        this.army = army;
        this.warehouse = warehouse;
    }

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();

        if (data[0].Equals("Soldier"))
        {
            string type = string.Empty;
            string name = string.Empty;
            int age = 0;
            int experience = 0;
            double speed = 0d;
            double endurance = 0d;
            double motivation = 0;
            double maxWeight = 0d;

            if (data.Length == 3)
            {
                type = data[1];
                name = data[2];
            }
            else
            {
                type = data[1];
                name = data[2];
                age = int.Parse(data[3]);
                experience = int.Parse(data[4]);
                speed = double.Parse(data[5]);
                endurance = double.Parse(data[6]);
                motivation = double.Parse(data[7]);
                maxWeight = double.Parse(data[8]);
            }

            switch (type)
            {
                case "Ranker":
                    break;
                case "Corporal":
                    break;
                case "Special-Force":
                    break;
                case "Regenerate":
                    break;
                case "Vacation":
                    break;
                case "Bonus":
                    break;
            }

        }
        //    else if (data[0].Equals("WearHouse"))
        //    {
        //        string name = data[1];
        //        int number = int.Parse(data[2]);

        //        AddAmmunitions(AmmunitionFactory.CreateAmmunitions(name, number));
        //    }
        //    else if (data[0].Equals("Mission"))
        //    {
        //        this.MissionControllerField.PerformMission(new Easy());
        //    }
        //}

        //public string RequestResult()
        //{
        //    return Output.GiveOutput(result, army, wearHouse, this.MissionControllerField.MissionQueue.Count);
        //}

        //private void AddAmmunitions(IAmmunition ammunition)
        //{
        //    if (!this.WearHouse.ContainsKey(ammunition.Name))
        //    {
        //        this.WearHouse[ammunition.Name] = new List<IAmmunition>();
        //        this.WearHouse[ammunition.Name].Add(ammunition);
        //    }
        //    else
        //    {
        //        this.WearHouse[ammunition.Name][0].Number += ammunition.Number;
        //    }
        //}

        //private void AddSoldierToArmy(Soldier soldier, string type)
        //{
        //    if (!soldier.CheckIfSoldierCanJoinTeam())
        //    {
        //        throw new ArgumentException($"The soldier {soldier.Name} is not skillful enough {type} team");
        //    }

        //    if (!this.Army.ContainsKey(type))
        //    {
        //        this.Army[type] = new List<Soldier>();
        //    }
        //    this.Army[type].Add(soldier);
    }
}
