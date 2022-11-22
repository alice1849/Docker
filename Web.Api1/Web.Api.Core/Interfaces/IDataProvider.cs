using System;
using Web.Api1.Core.Entities;

namespace Web.Api1.Core.Interfaces
{
    public interface IDataProvider
    {
        void Create(Product product);
        Product Select(int id);
        void Update(Product product);
        void Delete(int id);
    }
}

