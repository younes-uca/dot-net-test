using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class PurchaseStateDaoImpl : Repository<PurchaseState>, PurchaseStateDao {

    public async Task<PurchaseState?> FindByCode(String code){
        return await FindIf(el => el.Code == code);
    }

    public async Task<int>  DeleteByCode(String code){
        return await DeleteIf(el => el.Code == code);
    }

    public new async Task<List<PurchaseState>> FindOptimized() {
        return await IncludedTable.Select(e => new PurchaseState{Id = e.Id, Reference = e.Reference}).ToListAsync();
    }



    public PurchaseStateDaoImpl(AppDbContext context) : base(context, context.PurchaseStates){
    }

}
