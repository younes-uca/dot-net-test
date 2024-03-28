using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Repository;

namespace DotnetGenerator.Dao.Facade;

public interface TagDao : IRepository<Tag> {

    Task<Tag?> FindByCode(String code);
    Task<int>  DeleteByCode(String code);




}
