using EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;
using EnocaCaseStudy.Application.Services;
using EnocaCaseStudy.Application;
using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Application.Repositories.ProductRepositories;

namespace EnocaCaseStudy.Persistance.Services;

public class ProductService : IProductService
{
    private readonly IProductCommandRepository _productCommandRepository;
    private readonly ICompanyService _companyService;

    private readonly IUnitOfWork _unitOfWork;
    public ProductService(IProductCommandRepository productCommandRepository, IUnitOfWork unitOfWork, ICompanyService companyService)
    {
        _productCommandRepository = productCommandRepository;
        _unitOfWork = unitOfWork;
        _companyService = companyService;
    }

    public async Task AddAsync(CreateProductCommand request)
    {
        try
        {
            var company = await _companyService.GetByIdAsync(request.CompanyId);
            if (company != null)
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
            else
                throw new Exception("Company is not found.");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
