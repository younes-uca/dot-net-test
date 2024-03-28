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

[Route("api/admin/clientCategory/")]
[ApiController]
public class ClientCategoryRest :  BaseController<ClientCategory, ClientCategoryDto, ClientCategoryService, ClientCategoryCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<ClientCategoryDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<ClientCategoryDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<ClientCategoryDto>> Create(ClientCategoryDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<ClientCategoryDto>> Update(ClientCategoryDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(ClientCategoryDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<ClientCategoryDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<ClientCategoryDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<ClientCategoryDto?>>> FindByCriteria(ClientCategoryCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<ClientCategoryDto?>>> FindPaginatedByCriteria(ClientCategoryCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public ClientCategoryRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
