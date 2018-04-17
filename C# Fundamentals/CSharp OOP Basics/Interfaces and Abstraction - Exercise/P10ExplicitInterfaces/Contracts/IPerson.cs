using System;
using System.Collections.Generic;
using System.Text;

namespace P10ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        string Name { get; }
        string Country { get; }
        string GetName();
    }
}
