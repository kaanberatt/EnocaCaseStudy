using EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;
using EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;
using EnocaCaseStudy.Domain.Entities;

namespace EnocaCaseStudy.Application.Services;

public interface ICompanyService
{
    Task AddAsync(CreateCompanyCommand request);
    Task UpdateAsync(UpdateCompanyCommand request);
    List<Company> GetListAll();
    Task<Company> GetByIdAsync(int id);
}
