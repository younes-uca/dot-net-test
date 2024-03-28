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

[Route("api/admin/purchaseState/")]
[ApiController]
public class PurchaseStateRest :  BaseController<PurchaseState, PurchaseStateDto, PurchaseStateService, PurchaseStateCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<PurchaseStateDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<PurchaseStateDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<PurchaseStateDto>> Create(PurchaseStateDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<PurchaseStateDto>> Update(PurchaseStateDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(PurchaseStateDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<PurchaseStateDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<PurchaseStateDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<PurchaseStateDto?>>> FindByCriteria(PurchaseStateCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<PurchaseStateDto?>>> FindPaginatedByCriteria(PurchaseStateCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public PurchaseStateRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
