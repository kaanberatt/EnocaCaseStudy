using EnocaCaseStudy.Domain.Entities;

namespace EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;

public record CreateProductCommandResponse
{
    public string Message { get; set; }

    public CreateProductCommandResponse()
	{
		string Message = "Created Product";
	}
}
