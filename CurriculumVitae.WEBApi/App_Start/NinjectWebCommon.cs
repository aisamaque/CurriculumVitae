[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CurriculumVitae.WEBApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CurriculumVitae.WEBApi.App_Start.NinjectWebCommon), "Stop")]

namespace CurriculumVitae.WEBApi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using CurriculumVitae.Domain.Interfaces.Application;
    using CurriculumVitae.Application;
    using CurriculumVitae.Domain.Interfaces.Service;
    using CurriculumVitae.Domain.Services;
    using CurriculumVitae.Domain.Interfaces.Repository;
    using CurriculumVitae.Data.Repository;
    using Ninject.Web.WebApi;
    using System.Web.Http;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IApplication<>)).To(typeof(Application<>));
            kernel.Bind<IProfileApplication>().To<ProfileApplication>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IProfileServices>().To<ProfileService>();

            kernel.Bind(typeof(IRepository<>)).To(typeof(RespositoryBase<>));
            kernel.Bind<IProfileRepository>().To<ProfileRepository>();
        }        
    }
}
