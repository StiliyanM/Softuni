namespace P06Twitter
{
    public class Client : IClient
    {
        public Client(ITweet tweet)
        {
            Tweet = tweet;

            WriteToConsole();
            SendToServer();
        }

        public ITweet Tweet { get; private set; }

        public void SendToServer()
        {

        }

        public void WriteToConsole()
        {
            System.Console.WriteLine(this.Tweet.Message);
        }
    }
}
