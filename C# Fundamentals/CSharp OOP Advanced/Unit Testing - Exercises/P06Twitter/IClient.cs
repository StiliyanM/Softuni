namespace P06Twitter
{
    public interface IClient
    {
        ITweet Tweet { get; }

        void WriteToConsole();

        void SendToServer();
    }
}
