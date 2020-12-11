using System;
using Volo.Abp.Modularity;

namespace Volo.Abp.AuditLogging
{
    [DependsOn(typeof(AbpAuditLoggingDomainSharedModule))]
    public class AbpAuditLoggingApplicationContractsModule : AbpModule
    {
    }
}
