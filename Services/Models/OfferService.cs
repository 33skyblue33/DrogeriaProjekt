using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;

namespace DrogeriaProjekt.Services.Models
{
    public class OfferService : IOfferService
    {
        private readonly IDatabaseService DatabaseService;

        public OfferService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;
        }

        public Task<bool> AddOfferAsync(Offer offer)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Offer>> GetAllOffersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetAllProductsAsync(Offer offer)
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
