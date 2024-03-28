using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface PurchaseStateDao : IRepository<PurchaseState> {

    Task<PurchaseState?> FindByCode(String code);
    Task<int>  DeleteByCode(String code);




}
