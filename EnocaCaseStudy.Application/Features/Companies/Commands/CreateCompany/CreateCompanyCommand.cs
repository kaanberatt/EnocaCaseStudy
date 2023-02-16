using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;

public record CreateCompanyCommand(string CompanyName,
                                   bool isConfirm,
                                   DateTime StartDate,
                                   DateTime FinishDate) :IRequest<CreateCompanyCommandResponse>;