public class Mood
{
    public Mood(int happinessAmount)
    {
        this.HappinessAmount = happinessAmount;
    }
    public string MoodName
    {
        get
        {
            return CalculateMood(this.HappinessAmount);
        }
    }

    private int HappinessAmount { get; set; }

    private string CalculateMood(int happinessAmount)
    {
        if(happinessAmount < -5)
        {
            return "Angry";
        }
        else if(happinessAmount <= 0)
        {
            return "Sad";
        }
        else if(happinessAmount <= 15)
        {
            return "Happy";
        }
        else
        {
            return "JavaScript";
        }
    }

}
