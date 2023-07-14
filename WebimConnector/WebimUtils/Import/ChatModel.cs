namespace WebimConnector.WebimUtils.Import
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	/// <summary>
	/// Модель чатов
	/// </summary>
	public class ChatModel
	{
		/// <summary>
		/// Чаты
		/// </summary>
		public List<Chats> Chats { get; set; }

		/// <summary>
		/// Идентификатор получены ли все чаты
		/// </summary>
		public bool more_chats_available { get; set; }	

		/// <summary>
		/// Следующее значение для получения коллекции чатов
		/// </summary>
		public string last_ts { get; set; }
	}

	/// <summary>
	/// Данные по контакту
	/// </summary>
	public class Visitor
	{
		/// <summary>
		/// Поля
		/// </summary>
		public Fields fields { get; set; }
	}

	/// <summary>
	/// Поля
	/// </summary>
	public class Fields
	{
		/// <summary>
		/// Идентификатор контакта
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Телефон
		/// </summary>
		public string Phone { get; set; }

		/// <summary>
		/// E-mail
		/// </summary>
		public string Email { get; set; }
	}

	/// <summary>
	/// Чаты
	/// </summary>
	public class Chats
	{

		/// <summary>
		/// Id оператора
		/// </summary>
		public string operator_id { get; set; }

		/// <summary>
		/// Id чата
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Дата создания 
		/// </summary>
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Сообщения
		/// </summary>
		public List<MessageModel> Messages { get; set; }

		/// <summary>
		/// Данные по контакту
		/// </summary>
		public Visitor visitor { get; set; }
	}

    public class MessageModel
	{
		/// <summary>
		/// Дата отправки сообщения
		/// </summary>
		[DataMember(Name = "created_at")]
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Сообщение
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// От кого действие
		/// </summary>
		public string King { get; set; }

		/// <summary>
		/// Id сообщения
		/// </summary>
		public string Id { get; set; } 
	}
}
