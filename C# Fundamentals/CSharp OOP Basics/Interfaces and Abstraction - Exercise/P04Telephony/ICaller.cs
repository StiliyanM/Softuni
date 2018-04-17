using System.Collections.Generic;

public interface ICaller
{
    List<string> Numbers { get; set; }

    string Call();
}
