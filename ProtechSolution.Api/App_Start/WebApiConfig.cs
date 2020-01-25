using Microsoft.Practices.Unity;
using ProtechSolution.Domain.Contracts;
using ProtechSolution.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using ProtechSolution.Infrastructure.DataContext;
using ProtechSolution.Infrastructure.Repositories;

namespace ProtechSolution.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web
            var container = new UnityContainer();
            //container.RegisterType<ProtechDbContext, ProtechDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepository, ExperienceRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IService, ExperienceService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
