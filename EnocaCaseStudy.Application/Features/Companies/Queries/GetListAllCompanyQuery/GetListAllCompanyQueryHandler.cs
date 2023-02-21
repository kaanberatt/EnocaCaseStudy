using EnocaCaseStudy.Application.Services;
using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Queries.GetListAllCompanyQuery;

public class GetListAllQueryHandler : IRequestHandler<GetListAllCompanyQuery, GetListAllCompanyQueryResponse>
{
    private readonly ICompanyService _companyService;

    public GetListAllQueryHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    public async Task<GetListAllCompanyQueryResponse> Handle(GetListAllCompanyQuery request, CancellationToken cancellationToken)
    {

        var companies = _companyService.GetListAll();
        return new()
        {
            companies = companies,
            isSuccess = true,   
            Message = "Listed companies"
        };
    }
}
