using CleanArchitectureUtility.Endpoints.WebApi.Controllers;
using KevinTemplate.Core.Contract.People.Commands;
using Microsoft.AspNetCore.Mvc;

namespace KevinTemplate.Endpoints.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PeopleController : BaseController
{
    public PeopleController()
    {
    }

    [HttpPost("CreatePerson")]
    public async Task<IActionResult> CreatePerson([FromBody] CreatePerson createPerson, CancellationToken cancellationToken)
    {
        return await Create<CreatePerson, Guid>(createPerson, cancellationToken);
    }
}