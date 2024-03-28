using System.ComponentModel.DataAnnotations;

namespace DotnetGenerator.Zynarator.Dto;

public abstract class AuditBaseDto : BaseDto
{
    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}