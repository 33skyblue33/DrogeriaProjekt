using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface IOfferService
    {
        public Task<ICollection<Offer>> GetAllOffersAsync();
        public Task<ICollection<Product>> GetAllProductsAsync(Offer offer);
        public Task<bool> AddOfferAsync(Offer offer);
        public Task<bool> UpdateOfferAsync(Offer offer);
        public Task<bool> RemoveOfferAsync(Offer offer);
        public Task<TimeSpan> GetOfferTimeLeftAsync(Offer offer);
        public Task<bool> HasOfferExpired(Offer offer);
    }
}
