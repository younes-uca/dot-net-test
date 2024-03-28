using DotnetGenerator.Zynarator.Criteria;

namespace DotnetGenerator.Dao.Criteria;

public class PurchaseCriteria: BaseCriteria
{
    public string? Reference { get; set; }
    public string? ReferenceLike { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public DateTime? PurchaseDateFrom { get; set; }
    public DateTime? PurchaseDateTo { get; set; }
    public string? Image { get; set; }
    public string? ImageLike { get; set; }
    public string? Total { get; set; }
    public string? TotalMin { get; set; }
    public string? TotalMax { get; set; }
    public string? Description { get; set; }
    public string? DescriptionLike { get; set; }

    public ClientCriteria? Client  { get; set; }
    public List<ClientCriteria>? Clients  { get; set; }
    public PurchaseStateCriteria? PurchaseState  { get; set; }
    public List<PurchaseStateCriteria>? PurchaseStates  { get; set; }
}
