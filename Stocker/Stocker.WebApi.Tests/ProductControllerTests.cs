using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocker.DataModel.Repositories;
using Stocker.DataModel.Entities;
using Stocker.WebApi.Controllers;
using System.Linq;

namespace Stocker.WebApi.Tests
{
    [TestClass]
    public class ProductControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var rep = new Repository<Product>();
            var typeRep = new Repository<ProductType>();

            var controller = new ProductController(rep);
            var productType = new ProductType() { IsActive = true, Name = "Test Type1", ProductTypeId = 8 };

            controller.AddNewProduct("Teste", productType, 15, 20);

            var products = rep.FindBy(x => x.Name == "Teste" && x.Type.ProductTypeId == productType.ProductTypeId && x.Cost == 20 && x.Amount == 15);

            Assert.IsNotNull(products);
            Assert.AreEqual(1, products.Count());

            rep.DeleteAll();
            typeRep.DeleteAll();
        }
    }
}
