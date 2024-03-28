using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface PurchaseItemDao : IRepository<PurchaseItem> {


    Task<List<PurchaseItem>?> FindByProductId(long id);
    Task<int> DeleteByProductId(long id);
    Task<List<PurchaseItem>?> FindByPurchaseId(long id);
    Task<int> DeleteByPurchaseId(long id);



}
