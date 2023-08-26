using Newtonsoft.Json;
using somchai_bn.Model;

namespace somchai_bn.BusinessFlow
{
    public abstract class BaseRepository
    {
        private readonly string filePath = string.Empty;
        public BaseRepository(string filePath)
        {
            this.filePath = filePath;
        }
        public List<T> GetEntity<T>() where T : BaseEntity
        {
            string dataString = File.ReadAllText($"{Environment.CurrentDirectory}/{filePath}");
            List<T> dataModel = JsonConvert.DeserializeObject<List<T>>(dataString)!;
            return dataModel;
        }
        public T CreateEntity<T>(T dataModel) where T : BaseEntity
        {
            List<T> originalData = GetEntity<T>();
            dataModel.Id = originalData.Count + 1;
            originalData.Add(dataModel);
            string dataString = JsonConvert.SerializeObject(originalData, Formatting.Indented)!;
            File.WriteAllText($"{Environment.CurrentDirectory}/{filePath}", dataString);
            return dataModel;
        }

    }
}
