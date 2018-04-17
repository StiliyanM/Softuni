namespace P11Threeuple
{
    public class Threeuple<First,Second,Third>
    {

        public Threeuple(First item1, Second item2, Third item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public First Item1 { get; set; }
        public Second Item2 { get; set; }
        public Third Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
