using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebApplication2.Repository;

namespace WebApplication2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICategoryMasterRepository, Repository.category>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}