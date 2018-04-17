using System;

public interface IBirthable : IIdentifiable
{
    string Name { get; set; }
    string Birthday { get; set; }
}
