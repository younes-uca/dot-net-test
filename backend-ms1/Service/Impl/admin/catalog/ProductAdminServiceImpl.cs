using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class ProductServiceImpl: Service<Product, ProductDao, ProductCriteria, ProductSpecification>, ProductService{




    public override async Task<Product?> FindByReferenceEntity(Product t){
        return await Repository.FindByCode(t.Code!);
    }
    public override async Task<int> DeleteByReferenceEntity(Product t){
        return await Repository.DeleteByCode(t.Code!);
    }


    public ProductServiceImpl(IContainer container) : base(container){
    }


}

