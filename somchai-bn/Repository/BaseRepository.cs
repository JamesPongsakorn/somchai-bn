using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2;
using Amazon;
using somchai_bn.Configuration;
using somchai_bn.Model;

namespace somchai_bn.BusinessFlow
{
    public class BaseRepository
    {
        private readonly DynamoDBContext context;
        public BaseRepository()
        {
            AmazonDynamoDBClient dynamoClient = new(
                AwsConfiguration.accessKey, AwsConfiguration.secretKey, AwsConfiguration.token, RegionEndpoint.USEast1);
            context = new(dynamoClient);
        }
        public List<T> GetEntity<T>() where T : EntityInterface
        {
            List<T> result = context.ScanAsync<T>(new List<ScanCondition>()).GetRemainingAsync()
                .GetAwaiter().GetResult();
            return result;
        }
        public void CreateEntity<T>(T dataModel) where T : EntityInterface
        {
            context.SaveAsync(dataModel).Wait();
        }

    }
}
