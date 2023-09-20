using System;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace Volo.Abp.AuditLogging
{
    [DependsOn(typeof(AbpAuditLoggingDomainSharedModule),
        typeof(AbpMultiTenancyAbstractionsModule))]
    public class AbpAuditLoggingApplicationContractsModule : AbpModule
    {
    }
}
