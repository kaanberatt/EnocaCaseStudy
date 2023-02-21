using EnocaCaseStudy.Domain.Entities;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;

public class UpdateCompanyCommandResponse
{
    public string Message { get; set; }
    public bool isSuccess { get; set; }
}