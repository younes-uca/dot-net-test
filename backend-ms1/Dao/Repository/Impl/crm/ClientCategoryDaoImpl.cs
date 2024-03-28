using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class ClientCategoryDaoImpl : Repository<ClientCategory>, ClientCategoryDao {

    public async Task<ClientCategory?> FindByCode(String code){
        return await FindIf(el => el.Code == code);
    }

    public async Task<int>  DeleteByCode(String code){
        return await DeleteIf(el => el.Code == code);
    }

    public new async Task<List<ClientCategory>> FindOptimized() {
        return await IncludedTable.Select(e => new ClientCategory{Id = e.Id, Reference = e.Reference}).ToListAsync();
    }



    public ClientCategoryDaoImpl(AppDbContext context) : base(context, context.ClientCategorys){
    }

}
