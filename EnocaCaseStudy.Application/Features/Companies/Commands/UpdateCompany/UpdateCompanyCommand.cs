using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;

public record UpdateCompanyCommand(int Id,
                                   TimeSpan StartDate,
                                   TimeSpan FinishDate) : IRequest<UpdateCompanyCommandResponse>;
