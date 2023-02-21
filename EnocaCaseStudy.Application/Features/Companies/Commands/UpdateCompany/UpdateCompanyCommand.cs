using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;

public class UpdateCompanyCommand : IRequest<UpdateCompanyCommandResponse>
{
        public int Id { get; set; }
        public bool isConfirm{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
}
