using System.Collections.Generic;

public interface IBrowser
{
    List<string> Sites { get; set; }

    string Browse();
}
