namespace _02.KingsGambit.Units
{
    using System;

    public class Footman : Unit
    {
        private bool isAlive;

        public Footman(string name)
            : base(name)
        {
            this.isAlive = true;
        }

        public override bool IsAlive => this.isAlive;

        public override void Respond(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {base.Name} is panicking!");
        }

        public override void Kill()
        {
            this.isAlive = false;
        }
    }
}