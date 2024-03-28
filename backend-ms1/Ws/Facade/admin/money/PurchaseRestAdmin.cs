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

[Route("api/admin/purchase/")]
[ApiController]
public class PurchaseRest :  BaseController<Purchase, PurchaseDto, PurchaseService, PurchaseCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<PurchaseDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<PurchaseDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<PurchaseDto>> Create(PurchaseDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<PurchaseDto>> Update(PurchaseDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(PurchaseDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<PurchaseDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<PurchaseDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<PurchaseDto?>>> FindByCriteria(PurchaseCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<PurchaseDto?>>> FindPaginatedByCriteria(PurchaseCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public PurchaseRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
