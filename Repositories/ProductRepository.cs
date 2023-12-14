using DataAccess.Models;
using DataAccess.Interfaces;

namespace DataAccess.Repositories;

public class ProductRepository : IProductRepository
{
    private AppDataContext _context;

    public ProductRepository()
    {
        _context = AppDataContext.GetInstance();
    }

    public Product GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products;
    }

    public void Add(Product entity)
    {
        _context.Products.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Product entity)
    {
        _context.Products.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public List<Product> findProductByCategory(Category category)
    {
        return _context.Products.Where( p => p.Category == category).ToList();
    }


}