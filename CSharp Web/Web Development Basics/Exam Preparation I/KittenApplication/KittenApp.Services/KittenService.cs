namespace KittenApp.Services
{
    using Contracts;
    using KittenApp.Services.Models;
    using System.Collections.Generic;
    using Data;
    using System.Linq;
    using KittenApp.Models;

    public class KittenService : IKittenService
    {
        private readonly KittenDbContext db = new KittenDbContext();

        public void Create(string name, int age, string breedName, string imageUrl)
        {

            var breed = db.Breeds.FirstOrDefault(b => b.Name == breedName);

            if(breed == null)
            {
                breed = new Breed
                {
                    Name = breedName
                };
            }
            var kitten = new Kitten
            {
                Name = name,
                Age = age,
                Breed = breed,
                ImageUrl = imageUrl
            };

            db.Add(kitten);

            db.SaveChanges();
        }

        IList<AllKitensViewModel> IKittenService.All()
        {
            return this.db.Kittens
                                  .Select(k => new AllKitensViewModel
                                  {
                                      Age = k.Age,
                                      Breed = k.Breed.Name,
                                      Name = k.Name,
                                      ImageUrl = k.ImageUrl
                                  }).ToList();

        }
    }
}
