using System;
using Web.Api1.Core.Entities;

namespace Web.Api1.Core.Interfaces
{
	public interface IProductService
	{
		void Create(Product product);
		Product Get(int id);
		void Update(Product product);
		void Delete(int id);
	}
}

