using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class PurchaseItemDaoImpl : Repository<PurchaseItem>, PurchaseItemDao {



    public async Task<List<PurchaseItem>?> FindByProductId(long id) {
        return await FindListIf(item => item.Product!.Id == id);
    }
    public async Task<int> DeleteByProductId(long id) {
        return await DeleteIf(item => item.Product!.Id == id);
    }
    public async Task<List<PurchaseItem>?> FindByPurchaseId(long id) {
        return await FindListIf(item => item.Purchase!.Id == id);
    }
    public async Task<int> DeleteByPurchaseId(long id) {
        return await DeleteIf(item => item.Purchase!.Id == id);
    }


    public PurchaseItemDaoImpl(AppDbContext context) : base(context, context.PurchaseItems){
    }
    protected override void SetContextEntry(PurchaseItem item){
        SetUnchangedEntry(item.Product);
        SetUnchangedEntry(item.Purchase);
    }

    protected override IQueryable<PurchaseItem> SetIncluded() {
        return Table
        .Include(a => a.Product)
        .Include(a => a.Purchase)
        ;
    }
}
