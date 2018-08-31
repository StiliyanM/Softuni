﻿namespace Forum.App.Commands
{
    using Forum.App.Contracts;

    public abstract class NavigationCommand : ICommand
    {
        private IMenuFactory menuFactory;

        protected NavigationCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length);

            IMenu menu = menuFactory.CreateMenu(menuName);

            return menu;
        }
    }
}