namespace _02.KingsGambit.Units
{
    using System;

    using _02.KingsGambit.Interfaces;

    public abstract class Unit : ISoldier, IRespondable, IKillable
    {
        protected Unit(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract void Respond(object sender, EventArgs e);

        public abstract bool IsAlive { get; }

        public abstract void Kill();
    }
}