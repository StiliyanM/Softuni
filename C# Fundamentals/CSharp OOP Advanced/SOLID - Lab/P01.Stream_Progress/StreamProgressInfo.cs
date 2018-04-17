namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private Stream stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(Stream stream)
        {
            this.stream = stream;
        }
    }
}
