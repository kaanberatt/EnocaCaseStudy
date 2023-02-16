using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Domain.Repositories.ProductRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.ProductRepositories;

public class ProductCommandRepository : CommandRepository<Product>, IProductCommandRepository
{
    public ProductCommandRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
