using EnocaCaseStudy.Application.Services;
using MediatR;
using System.Net;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;

        public CreateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            await _companyService.AddAsync(request);
            
            return new CreateCompanyCommandResponse()
            {
                message = "Company is created",
                isSuccess= true
            };
        }
    }
}
