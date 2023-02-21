using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Application.Repositories.OrderRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.OrderRepositories;

public class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
{
    public OrderCommandRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
