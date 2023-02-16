namespace EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;

public record UpdateCompanyCommandResponse
{
	public string Message{ get; set; }
	public UpdateCompanyCommandResponse()
	{
		string Message = "Updated Company";	
	}
}
