public class RaceDto
{
    public int Place { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int PP { get; set; }

    public int MoneyWon { get; set; }

    public override string ToString()
    {
        return $"{Place}. {Brand} {Model} {PP}PP - ${MoneyWon}";
    }
}