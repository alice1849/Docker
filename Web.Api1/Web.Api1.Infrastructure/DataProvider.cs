
using Web.Api1.Core.Configuration;
using Web.Api1.Core.Entities;
using Web.Api1.Core.Interfaces;
using Microsoft.Extensions.Options;

namespace Web.Api1.Infrastructure;

public class DataProvider : IDataProvider 
	{
    private readonly List<Product> _storage;

    private  int _idCount;

    private readonly DataProviderOptions _dataProviderOptions;

    public DataProvider(IOptions<DataProviderOptions> dataProviderOptions)
    {
        _dataProviderOptions = dataProviderOptions.Value;
        _storage = new List<Product>();
        _idCount = 0;
	}

    public void Create(Product product)
    {
        product.Id = _idCount;
        _storage.Add(product);
        _idCount++;
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

