using RestSharp;
using System.Collections.Generic;
using System.Linq;
using WebimConnector.Utils;
using WebimConnector.WebimUtils.Model;

namespace WebimConnector.WebimUtils.Import
{
	/// <summary>
	/// Хендлер по импорту чатов
	/// </summary>
	public class ImportChatsHandler
	{

		/// <summary>
		/// Получение всех чатов
		/// </summary>
		/// <returns>Список отделов</returns>
		public static IReadOnlyList<Chats> GetChats()
		{
			RestUtilsWebim help = new RestUtilsWebim();
			ChatModel chats = null;
			string since = "0";
			while (true)
			{
				chats = ConvertJsonHelper.ConvertJsonInModel<ChatModel>((string)help.Execute($"/api/v2/chats?since={since}", Method.Get));
				if (!chats.more_chats_available) break;
				else since = chats.last_ts.ToString();
			}
			return chats.Chats;
		}
	}
}
