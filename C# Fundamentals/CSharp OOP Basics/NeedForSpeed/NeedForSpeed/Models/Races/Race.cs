using System.Collections.Generic;

public abstract class Race
{
    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
    }

    public Dictionary<int, int> PrizeMoney => new Dictionary<int, int>
    {
        [1] = this.PrizePool - (this.PrizePool * 50) / 100,
        [2] = this.PrizePool - (this.PrizePool * 70) / 100,
        [3] = this.PrizePool - (this.PrizePool * 80) / 100,
    };

    public int Length { get; protected set; }

    public string Route { get; protected set; }

    public int PrizePool { get; protected set; }

    public List<Car> Participants { get; protected set; } = new List<Car>();

    public abstract List<RaceDto> GetWinners();

    public bool Closed { get; set; }
}

