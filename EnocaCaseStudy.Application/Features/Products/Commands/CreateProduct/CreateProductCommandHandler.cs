using EnocaCaseStudy.Application.Services;
using MediatR;

namespace EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
{
    private readonly IProductService _productService;

    public CreateProductCommandHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await _productService.AddAsync(request);
        return new()
        {
            isSuccess = true,
            Message = "Added Products"
        };
    }
}
