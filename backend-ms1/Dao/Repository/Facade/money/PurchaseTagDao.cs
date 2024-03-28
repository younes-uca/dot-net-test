using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface PurchaseTagDao : IRepository<PurchaseTag> {


    Task<List<PurchaseTag>?> FindByPurchaseId(long id);
    Task<int> DeleteByPurchaseId(long id);
    Task<List<PurchaseTag>?> FindByTagId(long id);
    Task<int> DeleteByTagId(long id);



}
