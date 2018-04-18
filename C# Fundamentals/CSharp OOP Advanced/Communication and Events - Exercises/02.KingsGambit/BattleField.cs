namespace _02.KingsGambit
{
    using System;

    public class BattleField
    {
        public event EventHandler<EventArgs> AttackHandler;

        public void Attack()
        {
            this.AttackHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}