using CQUplink.ServiceInterface;
using Funq;
using ServiceStack;
using ServiceStack.Api.OpenApi;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace CQUplink
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("CQUplink", typeof(LicenseService).Assembly)
        {
        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            SetConfig(new HostConfig {UseCamelCase = true});

            Plugins.Add(new OpenApiFeature());

            container.Register<IDbConnectionFactory>(
                new OrmLiteConnectionFactory(MapProjectPath("~/App_Data/db.sqlite"), SqliteDialect.Provider));
        }
    }
}