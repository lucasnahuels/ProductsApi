using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using ProductsApi;
using ProductsApi.Controllers;
using ProductsApi.Models;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllProducts_GetRecords()
        {
            // Arrange
            var logger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(logger.Object);

            // Act
            var result = controller.Get();

            //assert
            Assert.IsType<OkObjectResult>(result);
            var response = controller.Get() as OkObjectResult;
            var products = response.Value as List<Product>;
            Assert.NotNull(products);
            Assert.Equal(MockedData.Products.Count, products.Count);
        }

        [Fact]
        public void PutProduct_NonExistingProduct_ReturnsNotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(logger.Object);
            var product = new Product { Id = 10, Name = "Product 10", Price = 100.99m };

            // Act
            var result = controller.Put(product);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void DeleteProduct_ExistingProduct_ReturnsNoContent()
        {
            // Arrange
            var logger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(logger.Object);

            // Act
            var result = controller.Delete(4);
            
            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}