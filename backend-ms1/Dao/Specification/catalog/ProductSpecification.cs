using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class ProductSpecification: AbstractSpecification<Product, ProductCriteria>
{
    public ProductSpecification(AppDbContext context) : base(context.Products)
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
