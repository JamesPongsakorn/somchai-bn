using Amazon.DynamoDBv2.DataModel;
using Newtonsoft.Json;

namespace somchai_bn.Model;

[DynamoDBTable("http-crud-tutorial-items2")]
public class CountryByAirportEntity : EntityInterface
{
    [DynamoDBHashKey]
    public string id { get; set; } = string.Empty;
    public string airport { get; set; } = string.Empty;
    public string country { get; set; } = string.Empty;
    public string keyid { get; set; } = string.Empty;
}