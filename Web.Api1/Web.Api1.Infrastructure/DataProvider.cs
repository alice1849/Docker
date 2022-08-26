using System;
using Web.Api1.Core.Entities;
using Web.Api1.Core.Interfaces;

namespace Web.Api1.Infrastructure;

public class DataProvider : IDataProvider 
	{
    private readonly List<Product> _storage;

		public DataProvider()
		{
        _storage = new List<Product>();
		}

    public void Create(Product product)
    {
        _storage.Add(product);
    }

    public void Delete(int id)
    {
        int index = _storage.FindIndex(x => x.Id == id);
        _storage.RemoveAt(index);
    }

    public Product Select(int id)
    {
        return _storage.FirstOrDefault(x => x.Id == id);
    }

        public void Update(Product product)
    {
        int index = _storage.FindIndex(x => x.Id == product.Id);
        _storage[index] = product;
    }
}

