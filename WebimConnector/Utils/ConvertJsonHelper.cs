using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace WebimConnector.Utils
{
    /// <summary>
    /// Работа с json
    /// </summary>
    public static  class ConvertJsonHelper
    {
        /// <summary>
		/// Конвертирование json в модель
		/// </summary>
		/// <param name="content">Входная строка json</param>
		/// <returns>Конвертированная модель</returns>
		public static T ConvertJsonInModel<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }
    }
}
