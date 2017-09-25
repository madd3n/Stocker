using Stocker.DataModel;
using Stocker.DataModel.Entities;
using System.Web.Http;

namespace Stocker.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        public bool AddNewProduct(string name, ProductType type, int amount, decimal cost)
        {
            using (var context = new StockerModel())
            {

            }
        }
    }
}
