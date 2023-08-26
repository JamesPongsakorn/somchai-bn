using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon;
using Microsoft.AspNetCore.Mvc;
using somchai_bn.Flow;
using somchai_bn.Model;
using somchai_bn.Configuration;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DataModel;

namespace somchai_bn.Controllers;

[ApiController]
[Route("[controller]")]
public class InsuranceController : ControllerBase
{
    private readonly ILogger<InsuranceController> _logger;
    private readonly InsuranceFlow insuranceFlow;

    public InsuranceController(ILogger<InsuranceController> logger)
    {
        _logger = logger;
        insuranceFlow = new();
    }

    [HttpPut("countryByAirport")]
    public GetCountryResponse GetCountry([FromBody] GetCountryRequest request)
    {
        return insuranceFlow.GetCountryByAirport(request);
    }

    [HttpGet("transaction")]
    public GetTransactionResponse GetTransaction([FromQuery] string id)
    {
        return insuranceFlow.GetTransaction(id);
    }

    [HttpPost("transaction")]
    public PostTransactionResponse PostTransaction([FromBody] PostTransactionRequest request)
    {
        return insuranceFlow.PostTransaction(request);
    }
    [HttpGet("person")]
    public PersonEntity GetPerson([FromQuery] long id)
    {
        return insuranceFlow.GetPerson(id);
    }
    [HttpPost("person")]
    public PersonEntity PostPerson([FromBody] PersonEntity request)
    {
        return insuranceFlow.PostPerson(request);
    }
}
