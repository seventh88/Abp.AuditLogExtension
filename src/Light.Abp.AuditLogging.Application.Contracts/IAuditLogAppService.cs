using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Volo.Abp.AuditLogging
{
    public interface IAuditLogAppService
    {
        Task<PagedResultDto<AuditLogDto>> GetListAsync(QueryAuditLogDto input);
    }
}