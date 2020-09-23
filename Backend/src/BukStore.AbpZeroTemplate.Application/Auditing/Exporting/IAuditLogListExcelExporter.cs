using System.Collections.Generic;
using BukStore.AbpZeroTemplate.Auditing.Dto;
using BukStore.AbpZeroTemplate.Dto;

namespace BukStore.AbpZeroTemplate.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
