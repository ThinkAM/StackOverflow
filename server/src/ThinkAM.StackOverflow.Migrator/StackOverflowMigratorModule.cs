using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.StackOverflow.Configuration;
using ThinkAM.StackOverflow.EntityFrameworkCore;
using ThinkAM.StackOverflow.Migrator.DependencyInjection;

namespace ThinkAM.StackOverflow.Migrator
{
    [DependsOn(typeof(StackOverflowEntityFrameworkModule))]
    public class StackOverflowMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public StackOverflowMigratorModule(StackOverflowEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(StackOverflowMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                StackOverflowConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StackOverflowMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
