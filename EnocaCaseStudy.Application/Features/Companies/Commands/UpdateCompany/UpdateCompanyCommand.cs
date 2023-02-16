using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;

public record UpdateCompanyCommand(int Id,
                                   DateTime StartDate,
                                   DateTime FinishDate,
                                   bool isConfirm) : IRequest<UpdateCompanyCommandResponse>;
