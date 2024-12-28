using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrogeriaProjekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private IOfferService Service { get; set; }

        public OfferController(IOfferService service)
        {
            Service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Offer>> GetOffers()
        {
            return await Service.GetAllOffersAsync();
        }
    }
}
