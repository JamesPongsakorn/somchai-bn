using somchai_bn.BusinessFlow;
using somchai_bn.Model;

namespace somchai_bn.Flow
{
    public class GetCountryFlow
    {
        private BaseRepository repository;
        public GetCountryFlow()
        {
            repository = new BaseRepository();
        }
        public GetCountryResponse GetCountryByAirport(GetCountryRequest request)
        {
            List<CountryByAirportEntity> getCountryByAirport = repository.GetEntity<CountryByAirportEntity>();
            CountryByAirportEntity originalCountry = getCountryByAirport.First(x => x.id == request.originalAirport);
            CountryByAirportEntity destinationCountry = getCountryByAirport.First(x => x.id == request.destinationAirport);
            GetCountryResponse response = new()
            {
                originalCountry = originalCountry.country,
                originalKey = originalCountry.keyid,
                destinationCountry = destinationCountry.country,
                destinationKey = destinationCountry.keyid
            };
            return response;
        }
    }
}
