using EnocaCaseStudy.Domain.Entities;
using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Queries.GetListAllCompanyQuery;

public class GetListAllCompanyQueryResponse
{
    public List<Company> companies { get; set; }
    public bool isSuccess { get; set; }
    public string Message{ get; set; }
}
