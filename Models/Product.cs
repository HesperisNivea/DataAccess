using DataAccess.Interfaces;

namespace DataAccess.Models;

public class Product : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }

    public Category Category { get; set; }

    public List<Tag> Tags { get; set; } = new List<Tag>();
}