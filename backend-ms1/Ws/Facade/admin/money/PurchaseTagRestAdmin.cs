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

[Route("api/admin/purchaseTag/")]
[ApiController]
public class PurchaseTagRest :  BaseController<PurchaseTag, PurchaseTagDto, PurchaseTagService, PurchaseTagCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<PurchaseTagDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<PurchaseTagDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<PurchaseTagDto>> Create(PurchaseTagDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<PurchaseTagDto>> Update(PurchaseTagDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(PurchaseTagDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<PurchaseTagDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<PurchaseTagDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<PurchaseTagDto?>>> FindByCriteria(PurchaseTagCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<PurchaseTagDto?>>> FindPaginatedByCriteria(PurchaseTagCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public PurchaseTagRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
