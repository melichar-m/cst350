using activity1_mmelichar.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace activity1_mmelichar.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productList;
        public HardCodedSampleDataRepository()
        {
            productList = new List<ProductModel>();

            productList.Add(new ProductModel(1, "Product 1", 6.25m, "This is a product"));
            productList.Add(new ProductModel(2, "Product 1", 9.99m, "This is a product"));
            productList.Add(new ProductModel(3, "Product 1", 1.5m, "This is a product"));
            productList.Add(new ProductModel(4, "Product 1", 75.99m, "This is a product"));
            for (int i = 0; i < 100; i++)
            {
                productList.Add(new Faker<ProductModel>()
                    .RuleFor(p => p.Id, i + 5)
                    .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                    .RuleFor(p => p.Description, f => f.Rant.Review())
                    );
            }
        }
        public List<ProductModel> AllProducts()
        {
            return productList;
        }

        public bool Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}