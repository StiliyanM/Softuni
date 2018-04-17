namespace P14CatLady
{
    class Siamese : Cat
    {
        public int EarSize { get; set; }

        public override string ToString()
        {
            return $"Siamese {base.Name} {this.EarSize}";
        }
    }
}
