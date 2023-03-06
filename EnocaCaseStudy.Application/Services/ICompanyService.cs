using EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;
using EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;
using EnocaCaseStudy.Domain.Entities;

namespace EnocaCaseStudy.Application.Services;

public interface ICompanyService
{
    Task<CreateCompanyCommandResponse> AddAsync(CreateCompanyCommand request);
    Task<UpdateCompanyCommandResponse> UpdateAsync(UpdateCompanyCommand request);
    List<Company> GetListAll();
    Task<Company> GetByIdAsync(int id);
}
