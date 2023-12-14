using DataAccess.Models;

namespace DataAccess.Interfaces;

public interface IProductRepository : IRepository<Product, int>
{
    List<Product> findProductByCategory(Category category);
}