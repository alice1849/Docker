using System;
using Web.Api1.Core.Entities;

namespace Web.Api1.Core.Interfaces
{
	public interface IProductService
	{
		Product Create(Product product);
		Product Get(int id);
		bool Update(Product product, int productToUpdateId);
		bool Delete(int id);
	}
}

