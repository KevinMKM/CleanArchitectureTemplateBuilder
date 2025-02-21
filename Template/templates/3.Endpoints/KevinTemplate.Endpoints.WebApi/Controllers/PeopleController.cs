using CleanArchitectureUtility.Core.Domain.Exceptions;
using CleanArchitectureUtility.Endpoints.WebApi.Controllers;
using KevinTemplate.Core.Contract.People.Commands;
using KevinTemplate.Core.Domain.People.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace KevinTemplate.Endpoints.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PeopleController : BaseController
{
    public PeopleController()
    {
    }

    [HttpGet("CheckValueObject")]
    public IActionResult CheckFirstNameValueObject(string firstName)
    {
        FirstName fName1 = new(firstName);
        FirstName fName2 = new(firstName);
        return Ok(fName1 == fName2);
    }

    [HttpGet("ExceptionCheck")]
    public IActionResult CheckFirstNameValueObject()
    {
        try
        {
            FirstName firstName = new("d");
        }
        catch (InvalidValueObjectStateException ex)
        {
            return Ok(ex.ToString());
        }

        return BadRequest();
    }

    [HttpPost("CreatePerson")]
    public async Task<IActionResult> CreatePerson([FromBody] CreatePerson createPerson)
    {
        return await Create<CreatePerson, Guid>(createPerson);
    }
}