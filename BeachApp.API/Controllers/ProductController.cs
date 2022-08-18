using System.Threading.Tasks;
using BeachApp.Domain.Entities;
using BeachApp.Domain.Interfaces.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BeachApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IGenericRepository<Product> _repository;

        public ProductController(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new {
                Teste =  await _repository.GetAllEntityAsync(1)
            });
        }
        
    }
}