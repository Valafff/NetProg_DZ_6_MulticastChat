using System.Text.Json;

namespace ConfigSerializeDeserialize
{
	static public class ConfigWriteReadJson
	{
		//Полная перезапись конфигурационного файла
		static public void ReWriteConfig(object _body, string _path)
		{
			using (FileStream fs = new FileStream(_path, FileMode.Create))
			{
				JsonSerializer.Serialize(fs, _body, new JsonSerializerOptions { WriteIndented = true });
			}
		}
		//Чтение конфигурационного файла
		static public T? ReadConfig<T>(string _path)
		{
			using (FileStream reader = new FileStream(_path, FileMode.Open))
			{
				return JsonSerializer.Deserialize<T>(reader);
			}
		}
	}
}
