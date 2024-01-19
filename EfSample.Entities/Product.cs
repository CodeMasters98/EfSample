namespace EfSample.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreationDate { get; set; }

    public int BrandId { get; set; }
    public Brand Brand { get; set; }

    public ICollection<Tag> Tags { get; set; }
}