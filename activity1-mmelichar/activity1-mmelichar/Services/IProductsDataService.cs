using activity1_mmelichar.Models;
using System.Collections.Generic;

namespace activity1_mmelichar
{
    public interface IProductDataService
    {
        List<ProductModel> AllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        bool Delete(ProductModel product);
        int Update(ProductModel product);
    }
}