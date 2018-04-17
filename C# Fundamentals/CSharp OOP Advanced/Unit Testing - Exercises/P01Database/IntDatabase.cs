namespace P01Database
{
    public class IntDatabase : Database<int>
    {
        public IntDatabase(params int[] values) : base(values)
        {
        }
    }
}
