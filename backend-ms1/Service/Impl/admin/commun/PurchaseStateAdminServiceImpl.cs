using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class PurchaseStateServiceImpl: Service<PurchaseState, PurchaseStateDao, PurchaseStateCriteria, PurchaseStateSpecification>, PurchaseStateService{




    public override async Task<PurchaseState?> FindByReferenceEntity(PurchaseState t){
        return await Repository.FindByCode(t.Code!);
    }
    public override async Task<int> DeleteByReferenceEntity(PurchaseState t){
        return await Repository.DeleteByCode(t.Code!);
    }


    public PurchaseStateServiceImpl(IContainer container) : base(container){
    }


}

