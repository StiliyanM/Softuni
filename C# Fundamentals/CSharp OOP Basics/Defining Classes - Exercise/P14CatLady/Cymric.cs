namespace P14CatLady
{
    class Cymric : Cat
    {
        public double FurLength { get; set; }

        public override string ToString()
        {
            return $"Cymric {base.Name} {this.FurLength:f2}"; 
        }
    }
}
