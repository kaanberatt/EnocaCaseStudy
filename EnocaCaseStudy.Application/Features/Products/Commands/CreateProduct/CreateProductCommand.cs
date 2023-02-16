using MediatR;

namespace EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;

public record CreateProductCommand(int CompanyId, string ProductName, decimal Stock, decimal Price) : IRequest<CreateProductCommandResponse>;
