using Stocker.DataModel;
using Stocker.DataModel.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Stocker.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        public bool AddNewProduct(string name, ProductType type, int amount, decimal cost)
        {
            try
            {
                using (var context = new StockerModel())
                {
                    var product = context.Product.FirstOrDefault(x => x.Name == name && x.Type == type);

                    if (product != null)
                    {
                        product.Amount += amount;

                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        [HttpGet]
        public Product GetProductById(int productId)
        {
            try
            {
                using (var context = new StockerModel())
                {
                    var product = context.Product.FirstOrDefault(x=>x.ProductId == productId);

                    return product;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public List<Product> GetProductsByName(string name)
        {
            return null;
        }
    }
}
