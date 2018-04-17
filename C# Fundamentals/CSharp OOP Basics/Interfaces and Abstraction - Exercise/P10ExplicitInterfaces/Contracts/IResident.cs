using System;
using System.Collections.Generic;
using System.Text;

namespace P10ExplicitInterfaces.Contracts
{
    interface IResident
    {
        string Name { get; }
        int Age { get; }
        string GetName();
    }
}
