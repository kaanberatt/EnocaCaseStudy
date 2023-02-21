using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Application.Repositories.CompanyRepositories;
using EnocaCaseStudy.Persistance.Context;

namespace EnocaCaseStudy.Persistance.Repositories.CompanyRepositories;

public class CompanyCommandRepository : CommandRepository<Company>, ICompanyCommandRepository
{
    public CompanyCommandRepository(EnocaCaseStudyContext context) : base(context)
    {
    }
}
