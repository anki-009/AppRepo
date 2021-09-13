using Microsoft.AspNetCore.Mvc;
using DemoMovies.Api.Controllers;
using DemoMovies.BL.Services;
using DemoMovies.Commons.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoMovies.Api.Tests
{
    [TestFixture]
    public class ProductsTest
    {
        protected Mock<IProductService> MockProductService;

        [SetUp]
        protected void Setup()
        {
            MockProductService = new Mock<IProductService>();
        }

        protected ProductController GetController()
        {
            return new ProductController(MockProductService.Object);
        }

        [Test]

        public void Should_ReturnProducts()
        {

            var products = new List<ProductModel> { new ProductModel() };
            MockProductService.Setup(s => s.GetProductsAsync()).Returns(Task.FromResult(products));

            //act
            var jsonAsyncResult = GetController().GetAvailableProducts();

            //assert
            var jsonResult = jsonAsyncResult.Result;
            Assert.IsInstanceOf<ObjectResult>(jsonResult);
        }
        [Test]
        public void Should_ReturnNotFound()
        {

            MockProductService.Setup(s => s.GetProductsAsync()).Returns(Task.FromResult(null as List<ProductModel>));

            //act
            var asyncResult = GetController().GetAvailableProducts();

            //assert
            var result = asyncResult.Result;
            Assert.IsInstanceOf<StatusCodeResult>(result);
        }
        [Test]
        [TestCase(1)]
        public void Should_ReturnProductsByCategory(int categoryid)
        {
            var products = new List<ProductModel> { new ProductModel() };
            MockProductService.Setup(s => s.GetProductsByCategory(It.IsAny<int>())).Returns(Task.FromResult(products));

            //act
            var jsonAsyncResult = GetController().GetProductByCategory(categoryid);

            //assert
            var jsonResult = jsonAsyncResult.Result;
            Assert.IsInstanceOf<ObjectResult>(jsonResult);
        }
    }
}