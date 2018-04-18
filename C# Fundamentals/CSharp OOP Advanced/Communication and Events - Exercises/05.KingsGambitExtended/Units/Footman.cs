namespace _02.KingsGambit.Units
{
    using System;

    public class Footman : Unit
    {
        private const int INNITIAL_LIFES = 2;

        private int life;
        private bool isAlive;

        public Footman(string name)
            : base(name)
        {
            this.isAlive = true;
            this.life = INNITIAL_LIFES;
        }

        public override bool IsAlive => this.isAlive;

        public override void Respond(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {base.Name} is panicking!");
        }

        public override void Kill()
        {
            this.life--;

            if (this.life <= 0)
            {
                this.isAlive = false;
            }
        }
    }
}