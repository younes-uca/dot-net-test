using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;

namespace DotnetGenerator.Service.Facade;

public interface PurchaseTagService: IService<PurchaseTag, PurchaseTagCriteria>{

    Task<List<PurchaseTag>?> FindByTagId(long id);

    Task<int> DeleteByTagId(long id);

}

