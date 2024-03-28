using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class PurchaseTagDaoImpl : Repository<PurchaseTag>, PurchaseTagDao {



    public async Task<List<PurchaseTag>?> FindByPurchaseId(long id) {
        return await FindListIf(item => item.Purchase!.Id == id);
    }
    public async Task<int> DeleteByPurchaseId(long id) {
        return await DeleteIf(item => item.Purchase!.Id == id);
    }
    public async Task<List<PurchaseTag>?> FindByTagId(long id) {
        return await FindListIf(item => item.Tag!.Id == id);
    }
    public async Task<int> DeleteByTagId(long id) {
        return await DeleteIf(item => item.Tag!.Id == id);
    }


    public PurchaseTagDaoImpl(AppDbContext context) : base(context, context.PurchaseTags){
    }
    protected override void SetContextEntry(PurchaseTag item){
        SetUnchangedEntry(item.Purchase);
        SetUnchangedEntry(item.Tag);
    }

    protected override IQueryable<PurchaseTag> SetIncluded() {
        return Table
        .Include(a => a.Purchase)
        .Include(a => a.Tag)
        ;
    }
}
