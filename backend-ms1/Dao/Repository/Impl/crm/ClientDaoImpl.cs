using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class ClientDaoImpl : Repository<Client>, ClientDao {

    public async Task<Client?> FindByEmail(String email){
        return await FindIf(el => el.Email == email);
    }

    public async Task<int>  DeleteByEmail(String email){
        return await DeleteIf(el => el.Email == email);
    }

    public new async Task<List<Client>> FindOptimized() {
        return await IncludedTable.Select(e => new Client{Id = e.Id, FullName = e.FullName}).ToListAsync();
    }

    public async Task<List<Client>?> FindByClientCategoryId(long id) {
        return await FindListIf(item => item.ClientCategory!.Id == id);
    }
    public async Task<int> DeleteByClientCategoryId(long id) {
        return await DeleteIf(item => item.ClientCategory!.Id == id);
    }


    public ClientDaoImpl(AppDbContext context) : base(context, context.Clients){
    }
    protected override void SetContextEntry(Client item){
        SetUnchangedEntry(item.ClientCategory);
    }

    protected override IQueryable<Client> SetIncluded() {
        return Table
        .Include(a => a.ClientCategory)
        ;
    }
}
