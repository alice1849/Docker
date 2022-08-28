using System;
using Microsoft.AspNetCore.Mvc;
using Web.Api1.Core.Entities;
using Web.Api1.Core.Interfaces;
using Web.Api1.Infrastructure;
using Web.Api1.Models;
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
        public void Post([FromBody] ProductModel product)
        {
            _productService.Create(new Product( product.Name, product.Price));
        }
        [HttpPut]
        public void Update([FromBody] ProductModel product)
        {
            _productService.Create(new Product(product.Name, product.Price));
        }
        [HttpDelete ("{id}")]
        public bool Delete(int id)
        {
            return _productService.Delete(id);
        }

    }
}

