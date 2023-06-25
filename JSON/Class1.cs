using Newtonsoft.Json;

namespace JSON
{
    public class Class1
    {
        public static void SaveToJson<T>(T data)
        {
            string filePath = "C:/Users/alexa/OneDrive/Рабочий стол/Практическая/WPFLib/WPFLib/data.json";

            List<T> dataList = new List<T>();

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                dataList = JsonConvert.DeserializeObject<List<T>>(jsonData);
            }

            dataList.Add(data);

            string updatedJsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            File.WriteAllText(filePath, updatedJsonData);
        }

        public static List<T> LoadFromJson<T>()
        {
            string filePath = "C:/Users/alexa/OneDrive/Рабочий стол/Практическая/WPFLib/WPFLib/data.json";

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(jsonData);
            }

            return new List<T>();
        }
    }
}