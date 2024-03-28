using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class PurchaseItemSpecification: AbstractSpecification<PurchaseItem, PurchaseItemCriteria>
{
    public PurchaseItemSpecification(AppDbContext context) : base(context.PurchaseItems)
    {
    }
    
    protected  override void ConstructPredicates()
    {
        AddPredicateId();

            AddPredicate(e => e.Price.EqualsDecimal(Criteria.Price));
            AddPredicate(e => e.Price.GreaterThen(Criteria.PriceMin));
            AddPredicate(e => e.Price.LessThen(Criteria.PriceMax));
            AddPredicate(e => e.Quantity.EqualsDecimal(Criteria.Quantity));
            AddPredicate(e => e.Quantity.GreaterThen(Criteria.QuantityMin));
            AddPredicate(e => e.Quantity.LessThen(Criteria.QuantityMax));

    AddPredicateIf(Criteria.Product is not null, e => e.Product!.Id == Criteria.Product!.Id);
    AddPredicateIf(Criteria.Products is not null, e => e.Product!.Id.In(Criteria.Products!.Ids()));
    AddPredicateIf(Criteria.Product is not null, e => e.Product!.Code == Criteria.Product!.Code);
    AddPredicateIf(Criteria.Purchase is not null, e => e.Purchase!.Id == Criteria.Purchase!.Id);
    AddPredicateIf(Criteria.Purchases is not null, e => e.Purchase!.Id.In(Criteria.Purchases!.Ids()));
    AddPredicateIf(Criteria.Purchase is not null, e => e.Purchase!.Reference == Criteria.Purchase!.Reference);
    }
}
