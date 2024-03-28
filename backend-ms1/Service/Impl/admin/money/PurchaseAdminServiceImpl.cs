using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class PurchaseServiceImpl: Service<Purchase, PurchaseDao, PurchaseCriteria, PurchaseSpecification>, PurchaseService{

    protected override void NullifyEntities(Purchase item)
    {
        if (item.Client!.Id == 0) item.Client = null;
        if (item.PurchaseState!.Id == 0) item.PurchaseState = null;
    }

    public override async Task<Purchase> Create(Purchase item) {
        PurchaseItem[]? purchaseItems = null ;
        if (item.PurchaseItems != null) {
            purchaseItems = new PurchaseItem[item.PurchaseItems!.Count];
            item.PurchaseItems.CopyTo(purchaseItems);
            item.PurchaseItems.Clear();
        }
        PurchaseTag[]? purchaseTags = null ;
        if (item.PurchaseTags != null) {
            purchaseTags = new PurchaseTag[item.PurchaseTags!.Count];
            item.PurchaseTags.CopyTo(purchaseTags);
            item.PurchaseTags.Clear();
        }
        await base.Create(item);
        if (purchaseItems != null) {
            foreach (var element in purchaseItems) {
                element.Purchase = item;
                await _purchaseItemService.Create(element);
                item.PurchaseItems!.Add(element);
            }
        }
        if (purchaseTags != null) {
            foreach (var element in purchaseTags) {
                element.Purchase = item;
                await _purchaseTagService.Create(element);
                item.PurchaseTags!.Add(element);
            }
        }
        return item;
    }

    public async Task<List<Purchase>?> FindByPurchaseStateId(long id) => await Repository.FindByPurchaseStateId(id);
    public async Task<int> DeleteByPurchaseStateId(long id) => await Repository.DeleteByPurchaseStateId(id);


    public override async Task<Purchase?> FindByReferenceEntity(Purchase t){
        return await Repository.FindByReference(t.Reference!);
    }
    public override async Task<int> DeleteByReferenceEntity(Purchase t){
        return await Repository.DeleteByReference(t.Reference!);
    }


    public PurchaseServiceImpl(IContainer container) : base(container){
        _purchaseTagService = container.GetInstance<PurchaseTagService>();
        _purchaseItemService = container.GetInstance<PurchaseItemService>();
    }

    private PurchaseTagService _purchaseTagService;
    private PurchaseItemService _purchaseItemService;

}

