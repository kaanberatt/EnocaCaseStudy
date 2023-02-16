namespace EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;

public record CreateOrderCommandResponse
{
    public string Message { get; set; }

    public CreateOrderCommandResponse()
	{
		string Message = "Order is completed";
	}
}
