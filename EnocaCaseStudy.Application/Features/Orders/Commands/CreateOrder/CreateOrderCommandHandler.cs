using EnocaCaseStudy.Application.Services;
using MediatR;

namespace EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
{
    private readonly IOrderService _orderService;
    private readonly ICompanyService _companyService;
    public CreateOrderCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var company = await _companyService.GetByIdAsync(request.CompanyId);
        if (company != null)
        {
            if (company.isConfirm)
            {
                TimeSpan NowTime = DateTime.Now.TimeOfDay;
                if (company.OrderAllowStartTime < NowTime && company.OrderAllowFinishTime > NowTime)
                {
                    await _orderService.AddAsync(request);
                    return new CreateOrderCommandResponse();
                }
                else
                    throw new Exception("Company closed");
            }
            else
                throw new Exception("Company is not confirm");
            
        }
        else
            throw new Exception("Company is not found");
    }
}
