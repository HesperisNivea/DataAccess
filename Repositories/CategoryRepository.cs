using DataAccess.Interfaces;
using DataAccess.Models;

namespace DataAccess.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private AppDataContext _context;

    public CategoryRepository()
    {
        _context = AppDataContext.GetInstance();
    }
    public Category GetById(int id)
    {
        return _context.Categories.Find(id);
    }

    public IEnumerable<Category> GetAll()
    {
        return _context.Categories;
    }

    public void Add(Category entity)
    {
        _context.Categories.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Category entity)
    {
        _context.Categories.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var category = _context.Categories.Find(id);
        _context.Categories.Remove(category);
        _context.SaveChanges();
    }
}