using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Domain.Repositories;
using EnocaCaseStudy.Domain.Repositories.ProductRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.ProductRepositories;

public class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
{
    public ProductQueryRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
