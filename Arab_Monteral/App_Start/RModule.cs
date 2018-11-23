using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arab_Monteral.App_Start
{
   
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //any class on name space data end with Repository now is registerd 
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("Data"))

                .Where(t => t.Name.EndsWith("Repository"))

                .AsImplementedInterfaces()

                .InstancePerLifetimeScope();
        }
    }

    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //the same with services any class in project Service and its name end with Service is registerd
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("Service"))

                .Where(t => t.Name.EndsWith("Service"))

                .AsImplementedInterfaces()

                .InstancePerLifetimeScope();
        }
    }
}