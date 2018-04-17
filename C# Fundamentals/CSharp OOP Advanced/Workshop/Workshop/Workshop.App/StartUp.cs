using Forum.Data;
using System;

namespace Forum.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ResetDatabase();
        }

        private static void ResetDatabase()
        {
            using (var db = new ForumDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }

    }
}
