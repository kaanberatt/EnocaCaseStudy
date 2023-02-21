using EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EnocaCaseStudy.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
    {
        var result = await _mediator.Send(request);
        return Ok(result);
    }
}
