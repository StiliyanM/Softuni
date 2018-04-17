namespace P10Tuple
{
    public class MyTuple<First,Second>
    {

        public MyTuple(First item1, Second item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public First Item1 { get; set; }
        public Second Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
