using DotnetGenerator.Zynarator.Criteria;

namespace DotnetGenerator.Dao.Criteria;

public class PurchaseItemCriteria: BaseCriteria
{
    public string? Price { get; set; }
    public string? PriceMin { get; set; }
    public string? PriceMax { get; set; }
    public string? Quantity { get; set; }
    public string? QuantityMin { get; set; }
    public string? QuantityMax { get; set; }

    public ProductCriteria? Product  { get; set; }
    public List<ProductCriteria>? Products  { get; set; }
    public PurchaseCriteria? Purchase  { get; set; }
    public List<PurchaseCriteria>? Purchases  { get; set; }
}
