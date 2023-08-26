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

    public InsuranceController(ILogger<InsuranceController> logger)
    {
        _logger = logger;
    }

    [HttpPut("CountryByAirport")]
    public GetCountryResponse HealthCheck(GetCountryRequest request)
    {
        return new GetCountryFlow().GetCountryByAirport(request);
    }
}
