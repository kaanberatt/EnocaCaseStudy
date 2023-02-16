using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;

public record CreateCompanyCommand(string CompanyName,
                                   bool isConfirm,
                                   TimeSpan StartDate,
                                   TimeSpan FinishDate) :IRequest<CreateCompanyCommandResponse>;