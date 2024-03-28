using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class PurchaseStateSpecification: AbstractSpecification<PurchaseState, PurchaseStateCriteria>
{
    public PurchaseStateSpecification(AppDbContext context) : base(context.PurchaseStates)
    {
    }
    
    protected  override void ConstructPredicates()
    {
        AddPredicateId();

            AddPredicate(e => e.Reference.EqualsString(Criteria.Reference));
            AddPredicate(e => e.Reference.ContainsString(Criteria.ReferenceLike));
            AddPredicate(e => e.Code.EqualsString(Criteria.Code));
            AddPredicate(e => e.Code.ContainsString(Criteria.CodeLike));

    }
}
