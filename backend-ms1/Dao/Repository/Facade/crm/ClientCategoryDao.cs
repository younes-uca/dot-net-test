using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface ClientCategoryDao : IRepository<ClientCategory> {

    Task<ClientCategory?> FindByCode(String code);
    Task<int>  DeleteByCode(String code);




}
