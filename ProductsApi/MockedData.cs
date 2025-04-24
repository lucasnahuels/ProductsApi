using ProductsApi.Models;

namespace ProductsApi
{
    public static class MockedData
    {
        public static List<Product> Products { get; set; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 10.99m
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 20.99m
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 30.99m
            },
            new Product
            {
                Id = 4,
                Name = "Product 4",
                Price = 40.99m
            },
            new Product
            {
                Id = 5,
                Name = "Product 5",
                Price = 50.99m
            }
        };
    }
}
