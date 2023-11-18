using Newtonsoft.Json;
using System.IO;  

namespace SystemPraktyk
{
    public class JsonFileService
    {
        public void SaveObjectToFile<T>(T obj, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
