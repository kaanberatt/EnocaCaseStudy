using EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EnocaCaseStudy.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProducts(CreateProductCommand request) 
    {
        var result = await _mediator.Send(request);

        return Ok(result);
    }

}
