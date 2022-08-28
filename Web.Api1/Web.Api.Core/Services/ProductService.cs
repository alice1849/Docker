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

        public Product Create(Product product)
        {
            _dataProvider.Create(product);
            return product;
        }

        public bool Delete(int id)
        {
            if (id < 0)
            {
                return false;
            }
            var product = _dataProvider.Select(id);
            if (product != null)
            {
                _dataProvider.Delete(id);
                return true;
            }
            return false;
                
            
        }

        public Product Get(int id)
        {
            return _dataProvider.Select(id);
        }

        public bool Update(Product product)
        {
            var selectProduct = _dataProvider.Select(product.Id);
            if(selectProduct != null)
            {
                _dataProvider.Update(product);
                return true;
            }
            return false;
        }
    }
}

