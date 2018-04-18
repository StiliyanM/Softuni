using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KingsGambit.Units
{
    public class RoyalGuard : Unit
    {
        private const int INNITIAL_LIFES = 3;

        private int life;
        private bool isAlive;

        public RoyalGuard(string name) 
            : base(name)
        {
            this.isAlive = true;
            this.life = INNITIAL_LIFES;
        }

        public override bool IsAlive => this.isAlive;

        public override void Respond(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {base.Name} is defending!");

            this.life--;

            if (this.life <= 0)
            {
                this.isAlive = false;
            }
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