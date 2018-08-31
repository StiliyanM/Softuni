namespace SimpleMvc.Services
{
    using Contracts;
    using Data;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        public void Initialize()
        {
            using (var db = new NotesDbContext())
            {
                db.Database.Migrate();
            }
        }
    }
}
