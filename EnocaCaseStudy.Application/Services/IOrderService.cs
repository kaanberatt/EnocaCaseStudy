using EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

namespace EnocaCaseStudy.Application.Services;

public interface IOrderService
{
    Task<CreateOrderCommandResponse> AddAsync(CreateOrderCommand request);
}
