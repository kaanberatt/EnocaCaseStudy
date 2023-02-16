using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaCaseStudy.WebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CompaniesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCompanies()
    {
        return NoContent();
    }
    [HttpPost]
    public IActionResult AddCompanies() 
    {
        return NoContent();
    }

}
