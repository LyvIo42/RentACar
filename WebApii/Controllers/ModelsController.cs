﻿using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using Core.Application.Request;
using Core.Application.Response;
using Core.Persistence.Dynamic;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController: BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new() { PageRequest = pageRequest };
            GetListRepsonse<GetListModelListItemDto> response = await Mediator.Send(getListModelQuery);
            return Ok(response);
        }
        [HttpPost("GetList/ByDynamic")]
        public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery=null)
        {
            GetListByDynamicModelQuery getListByDynamicModelQuery = new() { PageRequest = pageRequest, DynamicQuery= dynamicQuery };
            GetListRepsonse<GetListByDynamicModelListItemDto> response = response = await Mediator.Send(getListByDynamicModelQuery);
            return Ok(response);
        }
    }
}
