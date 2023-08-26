using Microsoft.AspNetCore.Mvc;
using somchai_bn.Flow;
using somchai_bn.Model;

namespace somchai_bn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsuranceController : ControllerBase
    {
        private readonly ILogger<InsuranceController> _logger;

        public InsuranceController(ILogger<InsuranceController> logger)
        {
            _logger = logger;
        }

        [HttpPut("CountryFromAirport")]
        public GetCountryResponse HealthCheck(GetCountryRequest request)
        {
            return new GetCountryFlow().GetCountryByAirport(request);
        }
    }

}