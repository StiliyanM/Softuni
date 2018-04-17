using System.Collections.Generic;
using System.Linq;

public class Food
{
    private const int UnknownFoodsHappiness = -1;
    private Dictionary<string, int> HappinessByFoods = new Dictionary<string, int>
    {
        ["cram"] = 2,
        ["lembas"] = 3,
        ["apple"] = 1,
        ["melon"] = 1,
        ["honeycake"] = 5,
        ["mushrooms"] = - 10,
    };

    public int CalcuteHappinessAmount(string[] foods)
    {
        var happiness = 0;
        foreach (var food in foods.Select(f => f.ToLower()))
        {
            if (!HappinessByFoods.ContainsKey(food))
            {
                happiness += UnknownFoodsHappiness;
            }
            else
            {
                happiness += HappinessByFoods[food];
            }
        }

        return happiness;
    }
}
