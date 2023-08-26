using Newtonsoft.Json;
using somchai_bn.Model;

namespace somchai_bn.BusinessFlow
{
    public class CountryKeyRepository : BaseRepository
    {
        public CountryKeyRepository() : base("Database/CountryKey.json")
        {

        }
    }
}
