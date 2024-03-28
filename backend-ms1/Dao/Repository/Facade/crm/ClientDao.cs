using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface ClientDao : IRepository<Client> {

    Task<Client?> FindByEmail(String email);
    Task<int>  DeleteByEmail(String email);

    Task<List<Client>?> FindByClientCategoryId(long id);
    Task<int> DeleteByClientCategoryId(long id);



}
