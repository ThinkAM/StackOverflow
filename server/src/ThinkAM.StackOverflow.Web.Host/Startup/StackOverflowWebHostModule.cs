using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.StackOverflow.Configuration;

namespace ThinkAM.StackOverflow.Web.Host.Startup
{
    [DependsOn(
       typeof(StackOverflowWebCoreModule))]
    public class StackOverflowWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public StackOverflowWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StackOverflowWebHostModule).GetAssembly());
        }
    }
}
