using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface ProductDao : IRepository<Product> {

    Task<Product?> FindByCode(String code);
    Task<int>  DeleteByCode(String code);




}
