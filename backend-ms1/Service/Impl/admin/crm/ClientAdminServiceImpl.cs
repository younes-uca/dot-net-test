using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class ClientServiceImpl: Service<Client, ClientDao, ClientCriteria, ClientSpecification>, ClientService{

    protected override void NullifyEntities(Client item)
    {
        if (item.ClientCategory!.Id == 0) item.ClientCategory = null;
    }



    public override async Task<Client?> FindByReferenceEntity(Client t){
        return await Repository.FindByEmail(t.Email!);
    }
    public override async Task<int> DeleteByReferenceEntity(Client t){
        return await Repository.DeleteByEmail(t.Email!);
    }


    public ClientServiceImpl(IContainer container) : base(container){
    }


}

