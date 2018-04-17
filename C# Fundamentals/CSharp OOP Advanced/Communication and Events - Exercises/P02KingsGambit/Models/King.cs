namespace P02KingsGambit.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class King : INamable, IAttackable
    {
        public string Name { get; }

        private List<ISubordinate> subordinates;

        public King(string name)
        {
            Name = name;
        }

        public event GetAttackedEventHandler GetAttackedEvent;

        public void GetAttacked()
        {
            Console.WriteLine($"King {this.Name} is under attack!");

            if(this.GetAttackedEvent != null)
            {
                this.GetAttackedEvent.Invoke();
            }
        }

        public void AddSubordinate(ISubordinate subordinate)
        {
            this.subordinates.Add(subordinate);
            GetAttackedEvent += subordinate.ReactToAttack;
        }
    }
}
