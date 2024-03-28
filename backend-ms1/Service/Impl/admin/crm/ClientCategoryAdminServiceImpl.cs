using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class ClientCategoryServiceImpl: Service<ClientCategory, ClientCategoryDao, ClientCategoryCriteria, ClientCategorySpecification>, ClientCategoryService{




    public override async Task<ClientCategory?> FindByReferenceEntity(ClientCategory t){
        return await Repository.FindByCode(t.Code!);
    }
    public override async Task<int> DeleteByReferenceEntity(ClientCategory t){
        return await Repository.DeleteByCode(t.Code!);
    }


    public ClientCategoryServiceImpl(IContainer container) : base(container){
    }


}

