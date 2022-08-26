using System;
using Microsoft.AspNetCore.Mvc;
using Web.Api1.Core.Entities;
using Web.Api1.Core.Interfaces;
using Web.Api1.Infrastructure;
using WebApi1.Core.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route ("[controller]")]
	public class ProductController : ControllerBase

	{
        private readonly IProductService _productService;
		public ProductController(IProductService productService)
		{
            _productService = productService;
		}

        [HttpGet("{id}")]
		public Product Get(int id)
        {
            return _productService.Get(id);
        }
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productService.Create(product);
        }
        [HttpPut]
        public void Update([FromBody] Product product)
        {
            _productService.Create(product);
        }
        [HttpDelete ("{id}")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }

    }
}

