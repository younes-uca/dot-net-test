using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class TagSpecification: AbstractSpecification<Tag, TagCriteria>
{
    public TagSpecification(AppDbContext context) : base(context.Tags)
    {
    }
    
    protected  override void ConstructPredicates()
    {
        AddPredicateId();

            AddPredicate(e => e.Code.EqualsString(Criteria.Code));
            AddPredicate(e => e.Code.ContainsString(Criteria.CodeLike));
            AddPredicate(e => e.Reference.EqualsString(Criteria.Reference));
            AddPredicate(e => e.Reference.ContainsString(Criteria.ReferenceLike));

    }
}
