using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class PurchaseTagServiceImpl: Service<PurchaseTag, PurchaseTagDao, PurchaseTagCriteria, PurchaseTagSpecification>, PurchaseTagService{

    protected override void NullifyEntities(PurchaseTag item)
    {
        if (item.Purchase!.Id == 0) item.Purchase = null;
        if (item.Tag!.Id == 0) item.Tag = null;
    }

    public async Task<List<PurchaseTag>?> FindByTagId(long id) => await Repository.FindByTagId(id);
    public async Task<int> DeleteByTagId(long id) => await Repository.DeleteByTagId(id);




    public PurchaseTagServiceImpl(IContainer container) : base(container){
    }


}

