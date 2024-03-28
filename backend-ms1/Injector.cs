using Lamar;
using DotnetGenerator.Dao.Facade;
using DotnetGenerator.Dao.Impl;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Service.Impl;
using DotnetGenerator.Dao.Specification;

namespace DotnetGenerator;

public static class Injector
{

    public static void Inject(this ServiceRegistry registry)
    {
        registry.InjectRepositories().InjectSpecifications().InjectServices();
    }

    public static ServiceRegistry InjectServices(this ServiceRegistry registry)
    {
        // Inject the service here
                registry.For<TagService>().Use<TagServiceImpl>().Scoped();
        registry.For<PurchaseStateService>().Use<PurchaseStateServiceImpl>().Scoped();
        registry.For<PurchaseItemService>().Use<PurchaseItemServiceImpl>().Scoped();
        registry.For<PurchaseTagService>().Use<PurchaseTagServiceImpl>().Scoped();
        registry.For<PurchaseService>().Use<PurchaseServiceImpl>().Scoped();
        registry.For<ProductService>().Use<ProductServiceImpl>().Scoped();
        registry.For<ClientService>().Use<ClientServiceImpl>().Scoped();
        registry.For<ClientCategoryService>().Use<ClientCategoryServiceImpl>().Scoped();
        return registry;
    }

    public static ServiceRegistry InjectRepositories(this ServiceRegistry registry)
    {
        // Inject the repositories here
        registry.For<TagDao>().Use<TagDaoImpl>().Scoped();
        registry.For<PurchaseStateDao>().Use<PurchaseStateDaoImpl>().Scoped();
        registry.For<PurchaseItemDao>().Use<PurchaseItemDaoImpl>().Scoped();
        registry.For<PurchaseTagDao>().Use<PurchaseTagDaoImpl>().Scoped();
        registry.For<PurchaseDao>().Use<PurchaseDaoImpl>().Scoped();
        registry.For<ProductDao>().Use<ProductDaoImpl>().Scoped();
        registry.For<ClientDao>().Use<ClientDaoImpl>().Scoped();
        registry.For<ClientCategoryDao>().Use<ClientCategoryDaoImpl>().Scoped();
        return registry;
    }

    public static ServiceRegistry InjectSpecifications(this ServiceRegistry registry)
    {
        // Inject the specifications here
        registry.For<TagSpecification>().Use<TagSpecification>().Scoped();
        registry.For<PurchaseStateSpecification>().Use<PurchaseStateSpecification>().Scoped();
        registry.For<PurchaseItemSpecification>().Use<PurchaseItemSpecification>().Scoped();
        registry.For<PurchaseTagSpecification>().Use<PurchaseTagSpecification>().Scoped();
        registry.For<PurchaseSpecification>().Use<PurchaseSpecification>().Scoped();
        registry.For<ProductSpecification>().Use<ProductSpecification>().Scoped();
        registry.For<ClientSpecification>().Use<ClientSpecification>().Scoped();
        registry.For<ClientCategorySpecification>().Use<ClientCategorySpecification>().Scoped();
        return registry;
    }
}
