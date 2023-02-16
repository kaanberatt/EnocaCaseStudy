using EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

namespace EnocaCaseStudy.Application.Services;

public interface IOrderService
{
    Task AddAsync(CreateOrderCommand request);
}
