using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Service;
using DotnetGenerator.Dao.Criteria;

namespace DotnetGenerator.Service.Facade;

public interface PurchaseService: IService<Purchase, PurchaseCriteria>{


    Task<List<Purchase>?> FindByPurchaseStateId(long id);

    Task<int> DeleteByPurchaseStateId(long id);

}

