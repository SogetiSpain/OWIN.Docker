namespace Owin.Docker
{
    using Microsoft.Practices.Unity;
    using System.Web.Http;
    using Unity.WebApi;
    using System.Configuration;

    public static class UnityConfig
    {
        public static void Setup(HttpConfiguration config)
        {
            var container = new UnityContainer();
            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}