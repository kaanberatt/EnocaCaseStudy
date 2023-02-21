using EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;
using EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;
using EnocaCaseStudy.Application.Services;
using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Application.Repositories.CompanyRepositories;
using EnocaCaseStudy.Application;

namespace EnocaCaseStudy.Persistance.Services;
public class CompanyService : ICompanyService
{
    private readonly ICompanyCommandRepository _companyCommandRepository;
    private readonly ICompanyQueryRepository _companyQueryRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CompanyService(ICompanyCommandRepository companyCommandRepository, IUnitOfWork unitOfWork, ICompanyQueryRepository companyQueryRepository)
    {
        _companyCommandRepository = companyCommandRepository;
        _unitOfWork = unitOfWork;
        _companyQueryRepository = companyQueryRepository;
    }

    public async Task AddAsync(CreateCompanyCommand request)
    {
        var company = new Company()
        {
            CompanyName = request.CompanyName,
            OrderAllowStartTime =  request.StartDate,
            OrderAllowFinishTime = request.FinishDate,
            isConfirm = true,
            CreatedDate = DateTime.Now
        };
        await _companyCommandRepository.AddAsync(company);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(UpdateCompanyCommand request)
    {
        var company = await _companyQueryRepository.GetById(request.Id);
        if (company != null)
        {
            company.isConfirm = request.isConfirm; 
            company.OrderAllowStartTime = request.StartDate;
            company.OrderAllowFinishTime= request.FinishDate;
            company.UpdatedDate = DateTime.Now;

            _companyCommandRepository.Update(company);
            await _unitOfWork.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Company is not found");
        }

    }
    public List<Company> GetListAll()
    {
        return _companyQueryRepository.GetAll().ToList();
    }

    public async Task<Company> GetByIdAsync(int id)
    {
       return await _companyQueryRepository.GetById(id);
    }
}
