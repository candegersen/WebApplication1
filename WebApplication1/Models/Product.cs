using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models.Product;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public int Price { get; set; }
}