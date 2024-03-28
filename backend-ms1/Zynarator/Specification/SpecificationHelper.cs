using DotnetGenerator.Zynarator.Bean;
using DotnetGenerator.Zynarator.Criteria;
using DotnetGenerator.Zynarator.Util;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Zynarator.Specification;

public abstract class SpecificationHelper<TEntity, TCriteria> : Specification<TEntity>
    where TEntity : IBusinessObject
    where TCriteria : BaseCriteria
{
    public required TCriteria Criteria;
    protected bool Distinct;
    
    protected SpecificationHelper(IQueryable<TEntity> query) : base(query)
    {
    }

    public async Task<PaginatedList<TEntity>> PaginatedSearch()
    {
        var result = await Search();

        var start = Math.Clamp(Criteria.Page * Criteria.MaxResults, 0, result.Count);
        var count = Math.Min(Criteria.MaxResults, result.Count - start);

        return new PaginatedList<TEntity>()
        {
            List = result.GetRange(start, count),
            DataSize = result.Count
        };
    }

    protected void AddPredicateId()
    {
        AddPredicateIf(Criteria.Id is not null && Criteria.Id != 0, e => e.Id.Equals(Criteria.Id));
        AddPredicateIf(Criteria.NotId is not null && Criteria.NotId != 0, e => !e.Id.Equals(Criteria.NotId));
        AddPredicateIf(Criteria.IdsIn is not null && Criteria.IdsIn?.Count > 0, e => e.Id.In(Criteria.IdsIn));
        AddPredicateIf(Criteria.IdsNotIn is not null && Criteria.IdsNotIn?.Count > 0,
            e => e.Id.NotIn(Criteria.IdsNotIn));
    }

    public abstract void DefinePredicates();
}