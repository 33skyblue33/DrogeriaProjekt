using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface IOfferService
    {
        public Task<bool> AddOfferAsync(Offer offer);
        public Task<List<Offer>> GetAllOffersAsync();
        public Task<List<Product>> GetAllProductsAsync(Offer offer);
        public Task<bool> UpdateOfferAsync(Offer offer);
        public Task<bool> RemoveOfferAsync(Offer offer);
        public Task<TimeSpan> GetOfferTimeLeftAsync(Offer offer);
        public Task<bool> HasOfferExpired(Offer offer);
    }
}
