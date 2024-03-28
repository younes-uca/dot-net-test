using AutoMapper;
using DotnetGenerator.Zynarator.Controller;
using DotnetGenerator.Zynarator.Security.Bean;
using DotnetGenerator.Zynarator.Security.Common;
using DotnetGenerator.Zynarator.Security.Dao.Criteria;
using DotnetGenerator.Zynarator.Security.Payload.Request;
using DotnetGenerator.Zynarator.Security.Service.Facade;
using DotnetGenerator.Zynarator.Security.Ws.Dto;
using DotnetGenerator.Zynarator.Util;
using Lamar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetGenerator.Zynarator.Security.Ws.Facade;

[Route("api/role/")]
[Authorize(Roles = Roles.Admin)]
[ApiController]
public class RoleRest : BaseController<Role, RoleDto, RoleService, RoleCriteria>
{
    [HttpGet("id/{id:long}")]
    public override Task<ActionResult<RoleDto>> FindById(long id) => base.FindById(id);

    [HttpGet]
    public override Task<ActionResult<List<RoleDto>>> FindAll() => base.FindAll();

    [HttpPost]
    public override Task<ActionResult<RoleDto>> Create(RoleDto dto) => base.Create(dto);

    [HttpPut]
    public override Task<ActionResult<RoleDto>> Update(RoleDto dto) => base.Update(dto);

    [HttpDelete("id/{id:long}")]
    public override Task<ActionResult<int>> DeleteById(long id) => base.DeleteById(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(RoleDto dto) => base.Delete(dto);

    [HttpPost("multiple")]
    public override Task<ActionResult<int>> Delete(List<RoleDto> dtos) => base.Delete(dtos);

    [HttpGet("optimized")]
    public override async Task<ActionResult<List<RoleDto?>>> FindOptimized()
    {
        return await base.FindOptimized();
    }

    [HttpPost("find-by-criteria")]
    public override async Task<ActionResult<List<RoleDto?>>> FindByCriteria(RoleCriteria criteria)
    {
        return await base.FindByCriteria(criteria);
    }

    [HttpPost("find-paginated-by-criteria")]
    public override async Task<ActionResult<PaginatedList<RoleDto?>>> FindPaginatedByCriteria(RoleCriteria criteria)
    {
        return await base.FindPaginatedByCriteria(criteria);
    }

    [HttpGet("authority/{authority}")]
    public async Task<ActionResult<RoleDto?>> FindByAuthority(string authority)
    {
        var result = await Service.FindByAuthority(authority);
        return ToDto(result);
    }

    public RoleRest(IContainer container, IMapper mapper) : base(container, mapper)
    {
    }
}