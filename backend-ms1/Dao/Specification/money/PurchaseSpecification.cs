using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class PurchaseSpecification: AbstractSpecification<Purchase, PurchaseCriteria>
{
    public PurchaseSpecification(AppDbContext context) : base(context.Purchases)
    {
    }
    
    protected  override void ConstructPredicates()
    {
        AddPredicateId();

            AddPredicate(e => e.Reference.EqualsString(Criteria.Reference));
            AddPredicate(e => e.Reference.ContainsString(Criteria.ReferenceLike));
            AddPredicate(e => e.PurchaseDate.EqualsDate(Criteria.PurchaseDate));
            AddPredicate(e => e.PurchaseDate.From(Criteria.PurchaseDateFrom));
            AddPredicate(e => e.PurchaseDate.To(Criteria.PurchaseDateTo));
            AddPredicate(e => e.Image.EqualsString(Criteria.Image));
            AddPredicate(e => e.Image.ContainsString(Criteria.ImageLike));
            AddPredicate(e => e.Total.EqualsDecimal(Criteria.Total));
            AddPredicate(e => e.Total.GreaterThen(Criteria.TotalMin));
            AddPredicate(e => e.Total.LessThen(Criteria.TotalMax));
            AddPredicate(e => e.Description.EqualsString(Criteria.Description));
            AddPredicate(e => e.Description.ContainsString(Criteria.DescriptionLike));

    AddPredicateIf(Criteria.Client is not null, e => e.Client!.Id == Criteria.Client!.Id);
    AddPredicateIf(Criteria.Clients is not null, e => e.Client!.Id.In(Criteria.Clients!.Ids()));
    AddPredicateIf(Criteria.Client is not null, e => e.Client!.Email == Criteria.Client!.Email);
    AddPredicateIf(Criteria.PurchaseState is not null, e => e.PurchaseState!.Id == Criteria.PurchaseState!.Id);
    AddPredicateIf(Criteria.PurchaseStates is not null, e => e.PurchaseState!.Id.In(Criteria.PurchaseStates!.Ids()));
    AddPredicateIf(Criteria.PurchaseState is not null, e => e.PurchaseState!.Code == Criteria.PurchaseState!.Code);
    }
}
