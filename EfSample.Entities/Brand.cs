﻿namespace EfSample.Entities;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }

    public ICollection<Product> Products { get; set; }
}
