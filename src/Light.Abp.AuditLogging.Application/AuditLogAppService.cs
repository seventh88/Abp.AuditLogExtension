using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Auditing;

namespace Volo.Abp.AuditLogging
{
    [DisableAuditing]
    public class AuditLogAppService : ApplicationService, IAuditLogAppService
    {
        private readonly IAuditLogRepository _auditLogRepository;

        public AuditLogAppService(IAuditLogRepository auditLogRepository)
        {
            _auditLogRepository = auditLogRepository;
        }

        //[Authorize(IdentityPermissions.Users.Default)]
        public virtual async Task<PagedResultDto<AuditLogDto>> GetListAsync(QueryAuditLogDto input)
        {
            var totalCount = await _auditLogRepository.GetCountAsync();
            var list = await _auditLogRepository.GetListAsync(
                input.Sorting,
                input.MaxResultCount,
                input.SkipCount,
                input.StartTime,
                input.EndTime,
                input.HttpMethod,
                input.Url,
                input.UserName,
                input.ApplicationName,
                input.CorrelationId,
                input.MaxExecutionDuration,
                input.MinExecutionDuration,
                input.HasException,
                input.HttpStatusCode
            );
            return new PagedResultDto<AuditLogDto>(totalCount, list.Select(x =>
                ObjectMapper.Map<AuditLog, AuditLogDto>(x))
                .ToList());
        }
    }
}
