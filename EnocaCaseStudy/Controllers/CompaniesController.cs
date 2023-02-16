using EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;
using EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;
using EnocaCaseStudy.Application.Features.Companies.Queries.GetListAllCompanyQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaCaseStudy.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CompaniesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CompaniesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> AddCompany(CreateCompanyCommand request)
    {
        var result = await _mediator.Send(request);
        return Ok(result.Message);
    }
    [HttpPost]
    public IActionResult UpdateCompany(UpdateCompanyCommand request)
    {
        var result = _mediator.Send(request);
        return Ok(result);
    }
    [HttpGet]
    public IActionResult GetAllCompanies() 
    {
        var request = new GetListAllCompanyQuery();
        var result = _mediator.Send(request);
        return Ok(result);
    }
    

}
