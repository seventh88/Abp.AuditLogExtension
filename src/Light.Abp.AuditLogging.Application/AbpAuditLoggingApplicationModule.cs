using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.AutoMapper;

namespace Volo.Abp.AuditLogging.Application
{
    [DependsOn(
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpAuditLoggingApplicationContractsModule)
    )]
    public class AbpAuditLoggingApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AbpAuditLoggingApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpAuditLoggingApplicationModule>();
            });
        }
    }
}
