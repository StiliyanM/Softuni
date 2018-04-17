using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Models
{
    using Contracts;
    public class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; }

        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public void Append(IError error)
        {
            Console.WriteLine(this.Layout);
        }
    }
}
