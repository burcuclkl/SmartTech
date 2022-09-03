using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using SmartTech.Business;
using SmartTech.Business.Factory;
using SmartTech.Business.Repository;
using SmartTech.Business.Service;
using SmartTech.Business.ServiceRepository;
using SmartTech.Business.UnitOfWork;
using System.Reflection;
using System.Web.Mvc;
using Autofac.Integration.Mvc;

namespace SmartTech.UI.App_Start
{
    public class AutoFacSettings
    {
        public static void Run()
        {
            //Arhitecture - IoC(Inversion Of Control)
            ContainerBuilder builder = new ContainerBuilder();

            //Controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Factory
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //Unit Of Work
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            //Repository
            builder.RegisterAssemblyTypes(Assembly.Load("SmartTech.Business")).Where(p => p.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();

            //Service
            builder.RegisterAssemblyTypes(Assembly.Load("SmartTech.Business")).Where(p => p.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();


            IContainer container = builder.Build();
            AutofacDependencyResolver autoFacResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(autoFacResolver);
        }
    }
}