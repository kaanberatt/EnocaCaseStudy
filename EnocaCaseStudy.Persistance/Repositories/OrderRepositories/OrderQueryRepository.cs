using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Domain.Repositories.OrderRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.OrderRepositories;

public class OrderQueryRepository : QueryRepository<Order>, IOrderQueryRepository
{
    public OrderQueryRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
