using MediatR;

namespace EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
{

        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
}
