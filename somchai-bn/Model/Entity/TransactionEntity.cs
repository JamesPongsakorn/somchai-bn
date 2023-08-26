using Amazon.DynamoDBv2.DataModel;
using Newtonsoft.Json;

namespace somchai_bn.Model;

[DynamoDBTable("transaction")]
public class TransactionEntity : EntityInterface
{
    [DynamoDBHashKey]
    public string id { get; set; } = string.Empty;
    public decimal amount { get; set; }
}