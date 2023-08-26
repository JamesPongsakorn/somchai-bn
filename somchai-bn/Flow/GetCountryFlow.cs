using somchai_bn.BusinessFlow;
using somchai_bn.Model;

namespace somchai_bn.Flow
{
    public class GetCountryFlow
    {
        private CountryKeyRepository hackathonRepository;
        public GetCountryFlow()
        {
            hackathonRepository = new CountryKeyRepository();
        }
        public GetCountryResponse GetCountryByAirport(GetCountryRequest request)
        {
            List<CountryByAirportEntity> getCountryByAirport = hackathonRepository.GetEntity<CountryByAirportEntity>();
            CountryByAirportEntity originalCountry = getCountryByAirport.First(x => x.From == request.originalAirport);
            CountryByAirportEntity destinationCountry = getCountryByAirport.First(x => x.From == request.destinationAirport);
            GetCountryResponse response = new()
            {
                originalCountry = originalCountry.Country,
                originalKey = originalCountry.KeyId,
                destinationCountry = destinationCountry.Country,
                destinationKey = destinationCountry.KeyId
            };
            return response;
        }
    }
}
