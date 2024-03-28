using AutoMapper;
using DotnetGenerator.Zynarator.Controller;
using DotnetGenerator.Zynarator.Security.Bean;
using DotnetGenerator.Zynarator.Security.Common;
using DotnetGenerator.Zynarator.Security.Dao.Criteria;
using DotnetGenerator.Zynarator.Security.Service.Facade;
using DotnetGenerator.Zynarator.Security.Ws.Dto;
using DotnetGenerator.Zynarator.Util;
using Lamar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetGenerator.Zynarator.Security.Ws.Facade;

[Route("api/actionPermission/")]
[Authorize(Roles = Roles.Admin)]
[ApiController]
public class ActionPermissionRest : BaseController<ActionPermission, ActionPermissionDto, ActionPermissionService,
    ActionPermissionCriteria>
{
    [HttpGet("id/{id:long}")]
    public override Task<ActionResult<ActionPermissionDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task<ActionResult<List<ActionPermissionDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<ActionPermissionDto>> Create(ActionPermissionDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<ActionPermissionDto>> Update(ActionPermissionDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(ActionPermissionDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<ActionPermissionDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<ActionPermissionDto?>>> FindOptimized()
    {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<ActionPermissionDto?>>> FindByCriteria(
        ActionPermissionCriteria criteria)
    {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<ActionPermissionDto?>>> FindPaginatedByCriteria(
        ActionPermissionCriteria criteria)
    {
        return await base.FindPaginatedByCriteria(criteria);
    }

    public ActionPermissionRest(IContainer container, IMapper mapper) : base(container, mapper)
    {
    }
}