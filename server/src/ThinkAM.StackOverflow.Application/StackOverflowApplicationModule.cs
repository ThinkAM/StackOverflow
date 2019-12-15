using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.StackOverflow.Authorization;

namespace ThinkAM.StackOverflow
{
    [DependsOn(
        typeof(StackOverflowCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StackOverflowApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StackOverflowAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StackOverflowApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
