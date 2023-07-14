using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Data;

namespace WebimConnector.WebimUtils
{
    /// <summary>
    /// класс для построения запросов в webim
    /// </summary>
    public class RestUtilsWebim
    {
        /// <summary>
        /// Логин
        /// </summary>
        private string _login;

        /// <summary>
        /// Пароль
        /// </summary>
        private string _password;

        /// <summary>
        /// Данные для авторизации запроса
        /// </summary>
        private string _authorization;

        /// <summary>
        /// Адрес сервиса webim
        /// </summary>
        private string _url;

        /// <summary>
        /// Конструктор
        /// </summary>
        public RestUtilsWebim()
        {
			var config = new ConfigurationBuilder()
			.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile("secrets.json")
			.AddUserSecrets<Program>()
			.Build();

			_url = config.GetConnectionString("ServerW");
			_login = config.GetConnectionString("LoginW");
			_password = config.GetConnectionString("PasswordW");

			_authorization = Base64Encode($"{_login}:{_password}");
		}

        /// <summary>
        /// Выполнение запроса
        /// </summary>
        /// <param name="action">Выполняемое действие</param>
        /// <param name="method">Метод запрса</param>
        /// <returns>Ответ завпроса</returns>
        public object Execute(string action, Method method)
        {
            var options = new RestClientOptions(_url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(action, method);
            request.AddHeader("Authorization", $"Basic {_authorization}");
            RestResponse response = client.Execute(request);
            return response.Content;
        }

        #region Method Private 

        /// <summary>
        /// Конвертирование строки в base64
        /// </summary>
        /// <param name="plainText">Текст</param>
        /// <returns>Строка в формате base64</returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        #endregion
    }
}
