namespace Forum.App.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Forum.App.Contracts;

    public class MenuFactory : IMenuFactory
    {
        private IServiceProvider serviceProvider;

        public MenuFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IMenu CreateMenu(string menuName)
        {
            Type menuType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == menuName);

            if (menuType == null)
            {
                throw new ArgumentException("Menu not found!");
            }

            if (!typeof(IMenu).IsAssignableFrom(menuType))
            {
                throw new ArgumentException($"{menuType} is not a menu!");
            }

            ParameterInfo[] constructorParametars = menuType.GetConstructors().First().GetParameters();

            object[] arguments = new object[constructorParametars.Length];

            for (int index = 0; index < constructorParametars.Length; index++)
            {
                arguments[index] = this.serviceProvider
                    .GetService(constructorParametars[index].ParameterType);
            }

            IMenu menu = (IMenu)Activator.CreateInstance(menuType, arguments);

            return menu;
        }
    }
}
