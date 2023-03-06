using EnocaCaseStudy.Application.Services;
using EnocaCaseStudy.Application.Repositories.CompanyRepositories;
using MediatR;

namespace EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
{
    private readonly IOrderService _orderService;
    private readonly ICompanyService _companyService;
    public CreateOrderCommandHandler(IOrderService orderService, ICompanyService companyService)
    {
        _orderService = orderService;
        _companyService = companyService;
    }

    public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var company = await _companyService.GetByIdAsync(request.CompanyId);
        if (company != null)
        {
            if (company.isConfirm)
            {
                TimeSpan startDate = company.OrderAllowStartTime.TimeOfDay;
                TimeSpan finishDate = company.OrderAllowFinishTime.TimeOfDay;

                TimeSpan NowTime = DateTime.Now.TimeOfDay;
                if (startDate < NowTime && finishDate > NowTime)
                {
                    var result = await _orderService.AddAsync(request);
                    return result;
                }
                else
                {
                    return new CreateOrderCommandResponse()
                    {
                        isSuccess = false,
                        Message = "The company does not accept orders."
                    };
                }
            }
            else
            {
                return new CreateOrderCommandResponse()
                {
                    isSuccess = false,
                    Message = "The Company is not confirm."
                };
            }
        }
        else
        {
            return new CreateOrderCommandResponse()
            {
                isSuccess = false,
                Message = "Company is not found."
            };
        }
    }
}
