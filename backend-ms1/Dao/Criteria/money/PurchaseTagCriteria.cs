using DotnetGenerator.Zynarator.Criteria;

namespace DotnetGenerator.Dao.Criteria;

public class PurchaseTagCriteria: BaseCriteria
{

    public PurchaseCriteria? Purchase  { get; set; }
    public List<PurchaseCriteria>? Purchases  { get; set; }
    public TagCriteria? Tag  { get; set; }
    public List<TagCriteria>? Tags  { get; set; }
}
