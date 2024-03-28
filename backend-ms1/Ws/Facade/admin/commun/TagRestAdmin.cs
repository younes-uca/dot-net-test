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

[Route("api/admin/tag/")]
[ApiController]
public class TagRest :  BaseController<Tag, TagDto, TagService, TagCriteria>
{

    [HttpGet("id/{id:long}")]
    public override Task <ActionResult<TagDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task <ActionResult<List<TagDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<TagDto>> Create(TagDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<TagDto>> Update(TagDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(TagDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<TagDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<TagDto?>>> FindOptimized() {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<TagDto?>>> FindByCriteria(TagCriteria criteria) {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<TagDto?>>> FindPaginatedByCriteria(TagCriteria criteria) {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public TagRest(IContainer container, IMapper mapper): base(container, mapper) {
    }
}
