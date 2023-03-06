using EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;

namespace EnocaCaseStudy.Application.Services
{
    public interface IProductService 
    {
        Task<CreateProductCommandResponse> AddAsync(CreateProductCommand request);
    }
}
