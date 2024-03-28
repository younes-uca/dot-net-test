using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using DotnetGenerator.Zynarator.Security.Bean;
using DotnetGenerator.Zynarator.Security.Dao.Repository.Facade;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Zynarator.Security.Dao.Repository.Impl;

public class ActionPermissionDaoImpl : Repository<ActionPermission>, ActionPermissionDao
{
    public async Task<ActionPermission?> FindByReference(string reference)
    {
        return await FindIf(el => el.Reference == reference);
    }

    public async Task<int> DeleteByReference(string reference)
    {
        return await DeleteIf(el => el.Reference == reference);
    }

    public new async Task<List<ActionPermission>> FindOptimized()
    {
        return await IncludedTable.Select(e => new ActionPermission { Id = e.Id, Reference = e.Reference })
            .ToListAsync();
    }


    public ActionPermissionDaoImpl(AppDbContext context) : base(context, context.ActionPermissions)
    {
    }
}