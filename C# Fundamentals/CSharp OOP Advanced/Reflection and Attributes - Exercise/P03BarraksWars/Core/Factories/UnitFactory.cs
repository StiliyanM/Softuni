namespace P03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == unitType);

            //if (type == null)
            //{
            //    throw new ArgumentException($"Invalid character type \"{type}\"!");
            //}

            var unit = (IUnit)Activator.CreateInstance(type);
            return unit;
        }
    }
}
