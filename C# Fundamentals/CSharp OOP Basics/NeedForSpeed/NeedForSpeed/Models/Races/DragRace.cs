using System.Collections.Generic;
using System.Linq;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override List<RaceDto> GetWinners()
    {
        var winners = this.Participants.OrderByDescending(p => p.EnginePerformance)
            .ThenBy(e => this.Participants.IndexOf(e))
            .Take(3).ToList();

        return winners    
            .Select(e => new RaceDto
            {
                Place = winners.IndexOf(e) + 1,
                Brand = e.Brand,
               Model = e.Model,
               PP = e.EnginePerformance,
               MoneyWon = this.PrizeMoney[winners.IndexOf(e) + 1]
            })
            .ToList();
    }
}