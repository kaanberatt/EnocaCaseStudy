using EnocaCaseStudy.Domain.Entities;

namespace EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;

public record CreateProductCommandResponse
{
	public CreateProductCommandResponse()
	{
		string Message = "Created Product";
	}
}
