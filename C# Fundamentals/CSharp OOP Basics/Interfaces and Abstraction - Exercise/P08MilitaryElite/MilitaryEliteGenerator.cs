using System;
using System.Collections.Generic;
using System.Linq;

public class MilitaryEliteGenerator
{
    private List<Soldier> soldiers = new List<Soldier>();
    private List<Private> privates = new List<Private>();

    internal string RegisterPrivate(string id, string firstName, string lastName, double salary)
    {
        var currentPrivate = new Private(firstName, lastName, id, salary);
        this.privates.Add(currentPrivate);
        return currentPrivate.ToString();
    }

    internal string RegisterLeutenantGeneral(string id, string firstName, string lastName, double salary, IEnumerable<string> privatesIds)
    {
        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(firstName, lastName, id, salary);

        leutenantGeneral.Privates = privatesIds.Select(pId => this.privates.First(p => p.Id == pId)).ToList();
        this.soldiers.Add(leutenantGeneral);
        return leutenantGeneral.ToString();
    }

    internal string RegisterEngineer(string id, string firstName, string lastName, double salary, string corpsInput, string[] repairsInput)
    {
        var isCorps = Enum.TryParse(corpsInput, false, out Corps corps);

        if (!isCorps)
        {
            return null;
        }
        Engineer engineer = new Engineer(firstName, lastName, id, salary);
        engineer.Corps = corps;

        for (int i = 0; i < repairsInput.Length; i += 2)
        {
            var repairPart = repairsInput[i];
            var repairHours = int.Parse(repairsInput[i + 1]);

            var repair = new Repair(repairPart, repairHours);

            engineer.Repairs.Add(repair);
        }

        this.soldiers.Add(engineer);

        return engineer.ToString();
    }

    internal string RegisterCommando(string id, string firstName, string lastName, double salary, string corpsInput, string[] missionsInput)
    {
        var isCorps = Enum.TryParse(corpsInput, false, out Corps corps);

        if (!isCorps)
        {
            return null;
        }
        Commando commando = new Commando(firstName, lastName, id, salary);

        for (int i = 0; i < missionsInput.Length; i+=2)
        {
            var codeName = missionsInput[i];

            var isStateValid = Enum.TryParse(missionsInput[i + 1], false, out State state);

            if (!isStateValid)
            {
                continue;
            }

            Mission mission = commando.Missions.FirstOrDefault(m => m.CodeName == codeName);
            if(state == State.Finished && mission != null)
            {
                mission.CompleteMission();
            }
            else
            {
                mission = new Mission(codeName, state);

                commando.Missions.Add(mission);
            }

        }

        this.soldiers.Add(commando);

        return commando.ToString();
    }

    internal string RegisterSpy(string id, string firstName, string lastName, int codeNumber)
    {
        var spy = new Spy(firstName, lastName, id, codeNumber);
        this.soldiers.Add(spy);

        return spy.ToString();
    }
}
