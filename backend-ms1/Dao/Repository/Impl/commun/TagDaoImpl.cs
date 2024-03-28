using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class TagDaoImpl : Repository<Tag>, TagDao {

    public async Task<Tag?> FindByCode(String code){
        return await FindIf(el => el.Code == code);
    }

    public async Task<int>  DeleteByCode(String code){
        return await DeleteIf(el => el.Code == code);
    }

    public new async Task<List<Tag>> FindOptimized() {
        return await IncludedTable.Select(e => new Tag{Id = e.Id, Reference = e.Reference}).ToListAsync();
    }



    public TagDaoImpl(AppDbContext context) : base(context, context.Tags){
    }

}
