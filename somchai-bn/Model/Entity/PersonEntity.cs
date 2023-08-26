using Amazon.DynamoDBv2.DataModel;
using Newtonsoft.Json;

namespace somchai_bn.Model;

[DynamoDBTable("person")]
public class PersonEntity : EntityInterface
{
    [DynamoDBHashKey]
    public long id { get; set; }
    public string transactionId { get; set; } = string.Empty;
    public string name { get; set; } = string.Empty;
    public string surname { get; set; } = string.Empty;
}