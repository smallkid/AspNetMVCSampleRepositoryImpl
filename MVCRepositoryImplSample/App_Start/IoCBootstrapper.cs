using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Autofac;
using Autofac.Integration.Mvc;
using darkstar.core;

namespace MVCRepositoryImplSample
{
    public class IoCBootstrapper
    {
        public static void RegisterDependencies() {
            var builder = new ContainerBuilder();
            var ctx = new CompanyCtx();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(x => new EmployeeRepository(ctx)).As<IEmployeeRepository>().InstancePerHttpRequest();
            builder.Register(x => new DepartmentRepository(ctx)).As<IDepartmentRepository>().InstancePerHttpRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}