using System;
namespace Web.Api1.Core.Entities
{
	public class Product
	{
        public int Id { get; set; }
        public string  Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            if (price == 0)
            {
                throw new ArgumentException("Price can not be zero");
            }

            Name = name;
            Price = price;

        }
	}
}

