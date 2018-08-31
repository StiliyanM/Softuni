namespace SimpleMvc.Framework.Security
{
    public class Authentication
    {
        internal Authentication(string name)
        {
            Name = name;
            this.IsAuthenticated = true;
        }

        internal Authentication()
        {
            this.IsAuthenticated = false;
        }

        public bool IsAuthenticated { get; }

        public string Name { get; }
    }
}
