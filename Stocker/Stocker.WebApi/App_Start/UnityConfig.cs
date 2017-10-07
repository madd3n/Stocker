using Microsoft.Practices.Unity;
using Stocker.DataModel.Entities;
using Stocker.DataModel.Repositories;
using System.Web.Http;
using Unity.WebApi;

namespace Stocker.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IRepository<Product>, Repository<Product>>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}