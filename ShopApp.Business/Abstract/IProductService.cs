using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        List<Product> GetProductsByCategory(string name, int page , int pageSize);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);  
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product Entity);
        int GetCountByCategory(string category);
        bool Update(Product entity, int[] categoryIds);

    }
}
