using System;
using Web.Api1.Core.Entities;
using Web.Api1.Core.Interfaces;

namespace WebApi1.Core.Services
{
	public class ProductService : IProductService
	{
        private IDataProvider _dataProvider;
		public ProductService(IDataProvider dataProvider)
		{
            _dataProvider = dataProvider;
		}

        public void Create(Product product)
        {
            _dataProvider.Create(product);
        }

        public void Delete(int id)
        {
            if (id <0)
            {
                return;
            }
            _dataProvider.Delete(id);
        }

        public Product Get(int id)
        {
            return _dataProvider.Select(id);
        }

        public void Update(Product product)
        {
            _dataProvider.Update(product);
        }
    }
}

