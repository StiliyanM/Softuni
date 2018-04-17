namespace P06Twitter
{
    public class Tweet : ITweet
    {
        public Tweet(string message)
        {
            this.Message = message;
        }

        public string Message { get; }
    }
}
