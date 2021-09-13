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
    public class CategoryTest
    {
        protected Mock<ICategoryService> MockCategoryService;

        [SetUp]
        protected void Setup()
        {
            MockCategoryService = new Mock<ICategoryService>();
        }

        protected CategoryController GetController()
        {
            return new CategoryController(MockCategoryService.Object);
        }

        [Test]

        public void Should_ReturnJson()
        {

            var category = new List<CategoryModel> { new CategoryModel() };
            MockCategoryService.Setup(s => s.GetCategoriesAsync()).Returns(Task.FromResult(category));
            //act
            var jsonAsyncResult = GetController().GetCategories();

            //assert
            var jsonResult = jsonAsyncResult.Result;
            Assert.IsInstanceOf<ObjectResult>(jsonResult);
        }


    }
}