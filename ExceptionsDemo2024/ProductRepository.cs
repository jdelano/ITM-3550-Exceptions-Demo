using System;
namespace ExceptionsDemo2024
{
	public class ProductRepository
	{
		public List<Product> SearchByPriceRange(double minPrice, double maxPrice)
		{
			if (minPrice >= maxPrice)
			{
				throw new InvalidPriceRangeException("The minimum price must be less than the maximum price.");
			}

			return GetAllProducts().Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();

		}


		public List<Product> GetAllProducts()
		{
			// Query the DB
			List<Product> products = new List<Product>
			{
				new Product { Name = "Chair", Price = 299.99 },
				new Product { Name = "Desk", Price = 1299.99 }
			};
			return products;
		}

		public ProductRepository()
		{
		}
	}
}

