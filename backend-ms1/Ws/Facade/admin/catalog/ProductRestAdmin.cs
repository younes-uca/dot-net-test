using AutoMapper;
using DotnetGenerator.Bean.Core;
using DotnetGenerator.Service.Facade;
using DotnetGenerator.Ws.Dto;
using DotnetGenerator.Zynarator.Controller;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using DotnetGenerator.Zynarator.Util;
using DotnetGenerator.Dao.Criteria;

namespace DotnetGenerator.WS.Facade;

[Route("api/admin/product/")]
[ApiController]
public class ProductRest :  BaseController<Product, ProductDto, ProductService, ProductCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<ProductDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<ProductDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<ProductDto>> Create(ProductDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<ProductDto>> Update(ProductDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(ProductDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<ProductDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<ProductDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<ProductDto?>>> FindByCriteria(ProductCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<ProductDto?>>> FindPaginatedByCriteria(ProductCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public ProductRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
