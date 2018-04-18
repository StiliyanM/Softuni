using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KingsGambit.Units
{
    public class RoyalGuard : Unit
    {
        private bool isAlive;

        public RoyalGuard(string name) 
            : base(name)
        {
            this.isAlive = true;
        }

        public override bool IsAlive => this.isAlive;

        public override void Respond(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {base.Name} is defending!");
        }

        public override void Kill()
        {
            this.isAlive = false;
        }
    }
}