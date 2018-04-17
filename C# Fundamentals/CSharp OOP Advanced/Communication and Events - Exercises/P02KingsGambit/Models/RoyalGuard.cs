namespace P02KingsGambit.Models
{
    using Contracts;

    public class RoyalGuard : Subordinate
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void ReactToAttack()
        {
            if(this.IsAlive)
            System.Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
