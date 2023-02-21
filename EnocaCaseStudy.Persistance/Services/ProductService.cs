using EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;
using EnocaCaseStudy.Application.Services;
using EnocaCaseStudy.Application;
using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Application.Repositories.ProductRepositories;

namespace EnocaCaseStudy.Persistance.Services;

public class ProductService : IProductService
{
    private readonly IProductCommandRepository _productCommandRepository;

    private readonly IUnitOfWork _unitOfWork;
    public ProductService(IProductCommandRepository productCommandRepository, IUnitOfWork unitOfWork)
    {
        _productCommandRepository = productCommandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task AddAsync(CreateProductCommand request)
    {
        var product = new Product()
        {
            CompanyId = request.CompanyId,
            ProductName = request.ProductName,
            Stock = request.Stock,
            Price = request.Price,
            CreatedDate = DateTime.Now,
        };
        await _productCommandRepository.AddAsync(product);
        await _unitOfWork.SaveChangesAsync();
    }
}
