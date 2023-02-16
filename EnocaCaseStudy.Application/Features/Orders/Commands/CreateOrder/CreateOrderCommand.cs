using MediatR;

namespace EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

public record CreateOrderCommand(int CompanyId,
                                 int ProductId,
                                 string CustomerName) : IRequest<CreateOrderCommandResponse>;
