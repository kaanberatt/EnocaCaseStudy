using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Domain.Repositories.CompanyRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.CompanyRepositories;

public class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
{
    public CompanyQueryRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
