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

[Route("api/admin/purchaseItem/")]
[ApiController]
public class PurchaseItemRest :  BaseController<PurchaseItem, PurchaseItemDto, PurchaseItemService, PurchaseItemCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<PurchaseItemDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<PurchaseItemDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<PurchaseItemDto>> Create(PurchaseItemDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<PurchaseItemDto>> Update(PurchaseItemDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(PurchaseItemDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<PurchaseItemDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<PurchaseItemDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<PurchaseItemDto?>>> FindByCriteria(PurchaseItemCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<PurchaseItemDto?>>> FindPaginatedByCriteria(PurchaseItemCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public PurchaseItemRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
