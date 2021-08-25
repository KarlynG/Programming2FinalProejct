using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingFinal.Test
{
    public class ProductServiceTest : BaseTests
    {
        [Fact]
        public async Task ShouldSaveProductAsync()
        {
            var product = new Products { Name = "Padalustro", Price = 200 };
            var result = await _productService.AddAsync(product);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetAllProductsAsync()
        {
            var result = await _productService.GetAllAsync();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task ShouldUpdateProductAsync()
        {
            var product = _productService.GetByIdAsync(2);
            product.Result.Name = "Juan";
            var result = await _productService.UpdateAsync(2, product.Result);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShoulDeleteProductByIdAsync()
        {
            var result = await _productService.DeleteByIdAsync(1);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetAllProductDataAsync()
        {
            var result = await _productService.GetProductAsyncData();

            Assert.NotEmpty(result);
        }
    }
}
