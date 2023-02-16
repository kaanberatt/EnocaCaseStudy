using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Queries.GetListAllCompanyQuery;

public record GetListAllCompanyQuery : IRequest<GetListAllCompanyQueryResponse>
{
}
