namespace SimpleMvc.Services
{
    using Contracts;
    using Data;
    using Models;
    public class NoteService : INoteService
    {
        public void Create(string title, string content, int userId)
        {
            using (var db = new NotesDbContext())
            {
                var note = new Note
                {
                    OwnerId = userId,
                    Title = title,
                    Content = content
                };

                db.Add(note);
                db.SaveChanges();
            }
        }
    }
}
