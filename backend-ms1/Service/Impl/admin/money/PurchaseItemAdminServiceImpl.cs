using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class PurchaseItemServiceImpl: Service<PurchaseItem, PurchaseItemDao, PurchaseItemCriteria, PurchaseItemSpecification>, PurchaseItemService{

    protected override void NullifyEntities(PurchaseItem item)
    {
        if (item.Product!.Id == 0) item.Product = null;
        if (item.Purchase!.Id == 0) item.Purchase = null;
    }





    public PurchaseItemServiceImpl(IContainer container) : base(container){
    }


}

