using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrogeriaProjekt.Services.Models
{
    public class OfferService : IOfferService
    {
        private readonly IDatabaseService DatabaseService;

        public OfferService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;

            var offers = new List<Offer>()
            {
                new Offer()
                {
                    Name = "Only Bio 30% Off",
                    Description = "All Only Bio hair products now 30% off!",
                    ImagePath = "promocja_only_bio.jpg",
                    Discount = 0.3f
                },
                new Offer()
                {
                    Name = "AA Laab 40% Off",
                    Description = "All AA Laab products now 40% off!",
                    ImagePath = "promocja_aa_cosmetics.jpg",
                    Discount = 0.4f
                },
                new Offer()
                {
                    Name = "Nivea Men 20% Off",
                    Description = "All Nivea Men products now 20% off!",
                    ImagePath = "promocja_nivea_men.jpg",
                    Discount = 0.2f
                }
            };

            DatabaseService.DatabaseContext.AddRange(offers);
            DatabaseService.DatabaseContext.SaveChanges();
        }

        public async Task<bool> AddOfferAsync(Offer offer)
        {
            await DatabaseService.DatabaseContext.Offers.AddAsync(offer);
            var result = await DatabaseService.DatabaseContext.SaveChangesAsync();

            return result > 0;
        }

        public Task<List<Offer>> GetAllOffersAsync()
        {
            return DatabaseService.DatabaseContext.Offers.ToListAsync();
        }

        public Task<List<Product>> GetAllProductsAsync(Offer offer)
        {
            throw new NotImplementedException();
        }

        public Task<TimeSpan> GetOfferTimeLeftAsync(Offer offer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasOfferExpired(Offer offer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveOfferAsync(Offer offer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOfferAsync(Offer offer)
        {
            throw new NotImplementedException();
        }
    }
}
