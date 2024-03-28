using DotnetGenerator.Bean.Core;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;
using DotnetGenerator.Dao.Specification;
using Lamar;

namespace DotnetGenerator.Service.Impl;


public class TagServiceImpl: Service<Tag, TagDao, TagCriteria, TagSpecification>, TagService{




    public override async Task<Tag?> FindByReferenceEntity(Tag t){
        return await Repository.FindByCode(t.Code!);
    }
    public override async Task<int> DeleteByReferenceEntity(Tag t){
        return await Repository.DeleteByCode(t.Code!);
    }


    public TagServiceImpl(IContainer container) : base(container){
    }


}

