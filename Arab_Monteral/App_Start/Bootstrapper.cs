using Autofac;
using Autofac.Integration.Mvc;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Data.Repositories;
using Service;
using System.Reflection;
using Arab_Monteral.Controllers;
using System.Web.Mvc;

namespace Arab_Monteral.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            //AutofacWebapiConfig.Initialize(config);

            SetAutofacContainer();

        }
       

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();


            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());

            Autofac.IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}