namespace P01.Stream_Progress
{
    public abstract class Stream
    {
        protected Stream(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;
        }
        public int Length { get; set; }

        public int BytesSent { get; set; }

        public int CalculateCurrentPercent => (this.BytesSent* 100) / this.Length;

        }

    }
}
