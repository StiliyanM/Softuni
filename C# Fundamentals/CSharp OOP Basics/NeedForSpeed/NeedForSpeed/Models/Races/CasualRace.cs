using System.Collections.Generic;
using System.Linq;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override List<RaceDto> GetWinners()
    {
        var winners = this.Participants.OrderByDescending(p => p.OverallPerfomance).Take(3).ToList();
        return winners
            .Select(e => new RaceDto
            {
                Place = winners.IndexOf(e) + 1,
                Brand = e.Brand,
                Model = e.Model,
                PP = e.OverallPerfomance,
                MoneyWon = this.PrizeMoney[winners.IndexOf(e) + 1]
            })
            .ToList();

    }
}
