using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Domain.Repositories.OrderRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.OrderRepositories;

public class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
{
    public OrderCommandRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
