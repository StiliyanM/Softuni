namespace Library.Services
{
    using Contracts;
    using Data;
    using Library.Models;
    using System.Linq;
    using System.Collections.Generic;
    using Library.Services.Models.Borrowers;

    public class BorrowerService : IBorrowerService
    {
        private readonly LibraryDbContext db;

        public BorrowerService()
        {
            this.db = new LibraryDbContext();
        }

        public void Create(string name, string address)
        {
            using (db)
            {
                var borrower = new Borrower
                {
                    Name = name,
                    Address = address
                };

                db.Add(borrower);
                db.SaveChanges();
            }
        }

        public bool Exists(string name)
        {
            return this.db.Borrowers.Any(b => b.Name == name);
        }

        public IEnumerable<AllBorrowersModel> All()
        {
            using (db)
            {
                return this.db.Borrowers
                        .Select(b => new AllBorrowersModel
                        {
                            Name = b.Name
                        }).ToList();

            }
        }
    }
}
