using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : IBrowser, ICaller
{
    public Smartphone(List<string> numbers, List<string> sites)
    {
        Numbers = numbers;
        Sites = sites;
    }

    public List<string> Sites { get; set; } = new List<string>();
    public List<string> Numbers { get; set; } = new List<string>();

    public string Browse()
    {
        var sb = new StringBuilder();

        foreach (var site in Sites)
        {
            if(site.Any(e => char.IsDigit(e)))
            {
                sb.AppendLine("Invalid URL!");
            }
            else
            {
                sb.AppendLine($"Browsing: {site}!");
            }
        }

        var result = sb.ToString().TrimEnd();

        return result;
    }

    public string Call()
    {
        var sb = new StringBuilder();

        foreach (var number in Numbers)
        {
            if (number.Any(e => !char.IsDigit(e)))
            {
                sb.AppendLine("Invalid number!");
            }
            else
            {
                sb.AppendLine($"Calling... {number}");
            }
        }

        var result = sb.ToString().TrimEnd();

        return result;

    }
}
