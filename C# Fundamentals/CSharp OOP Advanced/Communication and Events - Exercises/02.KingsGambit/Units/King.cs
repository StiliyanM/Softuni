using System;

namespace _02.KingsGambit.Units
{
    public class King : Unit
    {
        public King(string name) 
            : base(name)
        {

        }

        public override void Respond(object sender, EventArgs e)
        {
            Console.WriteLine($"King {base.Name} is under attack!");
        }

        public override bool IsAlive => true;

        public override void Kill()
        {
            throw new ApplicationException("Kings cannot be killed!");
        }
    }
}