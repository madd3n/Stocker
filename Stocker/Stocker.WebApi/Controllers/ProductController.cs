using Stocker.DataModel;
using Stocker.DataModel.Entities;
using Stocker.DataModel.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Stocker.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        IRepository<Product> _Products;

        public ProductController(IRepository<Product> products)
        {
            this._Products = products;
        }

        [HttpPost]
        public bool AddNewProduct(string name, ProductType type, int amount, decimal cost)
        {
            try
            {
                var product = this._Products.FindBy(x => x.Name == name && x.Type.ProductTypeId == type.ProductTypeId).FirstOrDefault();

                if (product != null)
                {
                    //already exists
                    return false;
                }
                else
                {
                    product = new Product();
                    product.Amount = amount;
                    product.Cost = cost;
                    product.Name = name;
                    product.Type = type;
                    product.IsActive = true;

                    this._Products.Add(product);
                }
                return false;
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
                return this._Products.FindBy(x => x.ProductId == productId).FirstOrDefault();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public List<Product> GetProductsByName(string name)
        {
            return this._Products.FindBy(x => x.Name == name).ToList();
        }

        [HttpPost]
        public bool RemoveProduct(int productId)
        {
            try
            {
                var product = this._Products.FindBy(x => x.ProductId == productId).FirstOrDefault();

                if (product != null)
                {
                    this._Products.Delete(product);
                    return true;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
    }
}
