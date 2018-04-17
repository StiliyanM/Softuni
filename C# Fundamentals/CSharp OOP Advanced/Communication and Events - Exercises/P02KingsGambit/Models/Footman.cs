namespace P02KingsGambit.Models
{
    using Contracts;

    public class Footman : Subordinate
    {
        public Footman(string name) : base(name)
        {
        }

        public override void ReactToAttack()
        {
            if(this.IsAlive)
            System.Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
