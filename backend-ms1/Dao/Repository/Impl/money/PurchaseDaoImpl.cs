using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class PurchaseDaoImpl : Repository<Purchase>, PurchaseDao {

    public async Task<Purchase?> FindByReference(String reference){
        return await FindIf(el => el.Reference == reference);
    }

    public async Task<int>  DeleteByReference(String reference){
        return await DeleteIf(el => el.Reference == reference);
    }

    public new async Task<List<Purchase>> FindOptimized() {
        return await IncludedTable.Select(e => new Purchase{Id = e.Id, Reference = e.Reference}).ToListAsync();
    }

    public async Task<List<Purchase>?> FindByClientId(long id) {
        return await FindListIf(item => item.Client!.Id == id);
    }
    public async Task<int> DeleteByClientId(long id) {
        return await DeleteIf(item => item.Client!.Id == id);
    }
    public async Task<List<Purchase>?> FindByPurchaseStateId(long id) {
        return await FindListIf(item => item.PurchaseState!.Id == id);
    }
    public async Task<int> DeleteByPurchaseStateId(long id) {
        return await DeleteIf(item => item.PurchaseState!.Id == id);
    }


    public PurchaseDaoImpl(AppDbContext context) : base(context, context.Purchases){
    }
    protected override void SetContextEntry(Purchase item){
        SetUnchangedEntry(item.Client);
        SetUnchangedEntry(item.PurchaseState);
        SetUnchangedEntry(item.PurchaseItems);
        SetUnchangedEntry(item.PurchaseTags);
    }

    protected override IQueryable<Purchase> SetIncluded() {
        return Table
        .Include(a => a.Client)
        .Include(a => a.PurchaseState)
        .Include(a => a.PurchaseItems)
        .Include(a => a.PurchaseTags)
        ;
    }
}
