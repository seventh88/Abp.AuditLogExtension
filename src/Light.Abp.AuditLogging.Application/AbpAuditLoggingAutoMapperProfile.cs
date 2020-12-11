using AutoMapper;

namespace Volo.Abp.AuditLogging
{
    public class AbpAuditLoggingAutoMapperProfile : Profile
    {
        public AbpAuditLoggingAutoMapperProfile()
        {

            CreateMap<AuditLog, AuditLogDto>().ReverseMap();

        }
    }
}
