using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override List<RaceDto> GetWinners()
    {
        var winners = this.Participants.OrderByDescending(p => p.SuspensionPerformance)
            .Take(3).ToList();
        return winners
                .Select(e => new RaceDto
                {
                    Place = winners.IndexOf(e) + 1,
                    Brand = e.Brand,
                    Model = e.Model,
                    PP = e.SuspensionPerformance,
                    MoneyWon = this.PrizeMoney[winners.IndexOf(e) + 1]
                })
                .ToList();

    }
}