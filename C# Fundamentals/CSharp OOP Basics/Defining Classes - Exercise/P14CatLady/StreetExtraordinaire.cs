namespace P14CatLady
{
    class StreetExtraordinaire : Cat
    {
        public int DecibelsOfMeows { get; set; }

        public override string ToString()
        {
            return $"StreetExtraordinaire {base.Name} {this.DecibelsOfMeows}";
        }
    }
}
