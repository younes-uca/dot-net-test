using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Specification;
using JasperFx.Core;

namespace DotnetGenerator.Dao.Specification;

public class ClientSpecification: AbstractSpecification<Client, ClientCriteria>
{
    public ClientSpecification(AppDbContext context) : base(context.Clients)
    {
    }
    
    protected  override void ConstructPredicates()
    {
        AddPredicateId();

            AddPredicate(e => e.FullName.EqualsString(Criteria.FullName));
            AddPredicate(e => e.FullName.ContainsString(Criteria.FullNameLike));
            AddPredicate(e => e.Email.EqualsString(Criteria.Email));
            AddPredicate(e => e.Email.ContainsString(Criteria.EmailLike));

    AddPredicateIf(Criteria.ClientCategory is not null, e => e.ClientCategory!.Id == Criteria.ClientCategory!.Id);
    AddPredicateIf(Criteria.ClientCategorys is not null, e => e.ClientCategory!.Id.In(Criteria.ClientCategorys!.Ids()));
    AddPredicateIf(Criteria.ClientCategory is not null, e => e.ClientCategory!.Code == Criteria.ClientCategory!.Code);
    }
}
