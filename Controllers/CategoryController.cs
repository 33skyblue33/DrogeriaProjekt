using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrogeriaProjekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService Service;

        public CategoryController(ICategoryService service)
        {
            Service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await Service.GetAllCategoriesAsync();
        }
    }
}
