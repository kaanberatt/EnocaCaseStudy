using EnocaCaseStudy.Domain.Entities;
using MediatR;

namespace EnocaCaseStudy.Application.Features.Companies.Queries.GetListAllCompanyQuery;

public record GetListAllCompanyQueryResponse(IQueryable<Company> companies);
