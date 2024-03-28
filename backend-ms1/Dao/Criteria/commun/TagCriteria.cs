using DotnetGenerator.Zynarator.Criteria;

namespace DotnetGenerator.Dao.Criteria;

public class TagCriteria: BaseCriteria
{
    public string? Code { get; set; }
    public string? CodeLike { get; set; }
    public string? Reference { get; set; }
    public string? ReferenceLike { get; set; }

}
