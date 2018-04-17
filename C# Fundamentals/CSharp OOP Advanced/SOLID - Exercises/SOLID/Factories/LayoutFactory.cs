using System;

namespace SOLID.Factories
{
    using Contracts;
    using Models;
    internal class LayoutFactory
    {
        public LayoutFactory()
        {
        }

        internal ILayout CreateLayout(string layoutType)
        {
            switch (layoutType)
            {
                case "SimpleLayout":
                    return new SimpleLayout();
                default:
                    throw new ArgumentException("Invalid Layout Type!");
            }
        }
    }
}