using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class ClientCategorySpecification: AbstractSpecification<ClientCategory, ClientCategoryCriteria>
{
    public ClientCategorySpecification(AppDbContext context) : base(context.ClientCategorys)
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
