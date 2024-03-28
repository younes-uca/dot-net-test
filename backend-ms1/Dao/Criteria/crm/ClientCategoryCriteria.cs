using DotnetGenerator.Zynarator.Criteria;

namespace DotnetGenerator.Dao.Criteria;

public class ClientCategoryCriteria: BaseCriteria
{
    public string? Reference { get; set; }
    public string? ReferenceLike { get; set; }
    public string? Code { get; set; }
    public string? CodeLike { get; set; }

}
