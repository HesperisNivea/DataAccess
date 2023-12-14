using DataAccess.Interfaces;

namespace DataAccess.Models;

public class Category : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Product> Products { get; set; } = new List<Product>();
}