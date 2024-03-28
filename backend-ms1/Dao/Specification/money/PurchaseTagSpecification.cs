using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class PurchaseTagSpecification: AbstractSpecification<PurchaseTag, PurchaseTagCriteria>
{
    public PurchaseTagSpecification(AppDbContext context) : base(context.PurchaseTags)
    {
    }
    
    protected  override void ConstructPredicates()
    {
        AddPredicateId();


    AddPredicateIf(Criteria.Purchase is not null, e => e.Purchase!.Id == Criteria.Purchase!.Id);
    AddPredicateIf(Criteria.Purchases is not null, e => e.Purchase!.Id.In(Criteria.Purchases!.Ids()));
    AddPredicateIf(Criteria.Purchase is not null, e => e.Purchase!.Reference == Criteria.Purchase!.Reference);
    AddPredicateIf(Criteria.Tag is not null, e => e.Tag!.Id == Criteria.Tag!.Id);
    AddPredicateIf(Criteria.Tags is not null, e => e.Tag!.Id.In(Criteria.Tags!.Ids()));
    AddPredicateIf(Criteria.Tag is not null, e => e.Tag!.Code == Criteria.Tag!.Code);
    }
}
