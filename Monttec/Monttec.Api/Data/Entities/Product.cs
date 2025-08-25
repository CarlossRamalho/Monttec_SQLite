using System.ComponentModel.DataAnnotations;

namespace Monttec.Api.Data.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }

    [Required, MaxLength(500)]
    public string? Description { get; set; }

    public decimal Price { get; set; }

    [Required]
    public string Stock { get; set; }

    public static Product[] GetSeedData()
    {
        const string ImageUrlPrefix = "https://res.cloudinary.com/monttec/image/upload/v1696116488/products/";

        Product[] products = [
            new () { Id = 1, Name = "Product 1", Description = "Description for Product 1", Price = 19.99M, Stock = $"{ImageUrlPrefix}product1.jpg" },
            ];
        return products;
    }

}
