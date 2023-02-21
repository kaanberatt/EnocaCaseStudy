using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;

public class CreateCompanyCommand : IRequest<CreateCompanyCommandResponse>
{
    public string CompanyName { get; set; }
    public bool IsConfirm { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime FinishDate { get; set; }
}