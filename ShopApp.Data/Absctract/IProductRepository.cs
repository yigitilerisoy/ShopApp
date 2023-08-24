using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Data.Absctract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(string url);
        List <Product> GetProductsByCategory(string name, int page  ,int pageSize);
        Product GetByIdWithCategories(int id);
        List<Product> GetSearchResult(string searchString);
        List<Product> GetTop5Products();
        List<Product> GetHomePageProducts();
        int GetCountByCategory(string category);

        void Update(Product entity, int[] categoryIds);



    }
}
