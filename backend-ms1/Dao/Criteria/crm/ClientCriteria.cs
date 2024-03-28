using DotnetGenerator.Zynarator.Criteria;

namespace DotnetGenerator.Dao.Criteria;

public class ClientCriteria: BaseCriteria
{
    public string? FullName { get; set; }
    public string? FullNameLike { get; set; }
    public string? Email { get; set; }
    public string? EmailLike { get; set; }

    public ClientCategoryCriteria? ClientCategory  { get; set; }
    public List<ClientCategoryCriteria>? ClientCategorys  { get; set; }
}
