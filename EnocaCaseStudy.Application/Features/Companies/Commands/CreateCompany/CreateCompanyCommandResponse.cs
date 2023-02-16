namespace EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;

public record CreateCompanyCommandResponse
{
	public string Message{ get; set; }
	public CreateCompanyCommandResponse()
	{
		Message = "Added Company";

	}
}
