namespace SimpleMvc.Services.Contracts
{
    public interface INoteService
    {
        void Create(string title, string content, int userId);
    }
}
