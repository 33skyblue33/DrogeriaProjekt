using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrogeriaProjekt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategoryService Service;

        public CategoryController(ICategoryService service)
        {
            Service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await Service.GetAllCategoriesAsync();
        }
    }
}
