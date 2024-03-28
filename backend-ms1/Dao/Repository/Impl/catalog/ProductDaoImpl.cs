using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Data;
using DotnetGenerator.Zynarator.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Dao.Impl;

public class ProductDaoImpl : Repository<Product>, ProductDao {

    public async Task<Product?> FindByCode(String code){
        return await FindIf(el => el.Code == code);
    }

    public async Task<int>  DeleteByCode(String code){
        return await DeleteIf(el => el.Code == code);
    }

    public new async Task<List<Product>> FindOptimized() {
        return await IncludedTable.Select(e => new Product{Id = e.Id, Reference = e.Reference}).ToListAsync();
    }



    public ProductDaoImpl(AppDbContext context) : base(context, context.Products){
    }

}
