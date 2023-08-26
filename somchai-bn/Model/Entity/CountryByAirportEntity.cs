using Newtonsoft.Json;

namespace somchai_bn.Model;

public class CountryByAirportEntity : BaseEntity
{
    public long Id { get; set; }
    public string From { get; set; } = string.Empty;
    public string Airport { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string KeyId { get; set; } = string.Empty;
}
