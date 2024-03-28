using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface PurchaseDao : IRepository<Purchase> {

    Task<Purchase?> FindByReference(String reference);
    Task<int>  DeleteByReference(String reference);

    Task<List<Purchase>?> FindByClientId(long id);
    Task<int> DeleteByClientId(long id);
    Task<List<Purchase>?> FindByPurchaseStateId(long id);
    Task<int> DeleteByPurchaseStateId(long id);



}
