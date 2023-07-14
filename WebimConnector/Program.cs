using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebimConnector.Utils;
using WebimConnector.WebimUtils;
using WebimConnector.WebimUtils.Import;
using WebimConnector.WebimUtils.Model;

namespace WebimConnector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Go");

			string action = Console.ReadLine();

			if (action.Equals("operators"))
            {
                foreach (OperatorModel oper in ImportOperatorsHandler.GetOperatord())
                {
                    Console.WriteLine($"{oper.Full_Name} {oper.Id} {oper.Email}");
                }
            }
			

			if (action.Equals("departments"))
			{
				foreach (DepartmentModel oper in ImportDepartmentHandler.GetDepartments())
				{
					Console.WriteLine($"{oper.Id} {oper.Id} {oper.Name}");
				}
			}

			if (action.Equals("chats"))
			{
				foreach (Chats chat in ImportChatsHandler.GetChats())
				{
					Console.WriteLine($"----------------------------------");
					Console.WriteLine($"chat: {chat.Id} {chat.operator_id}");
					Console.WriteLine($"contact: {chat.visitor.fields.Id} {chat.visitor.fields.Phone} {chat.visitor.fields.Email}");
					foreach (MessageModel message in chat.Messages)
					{
						Console.WriteLine($"message: {message.Id} {message.King} {message.CreatedAt} {message.Message}");
					}
					
				}
			}


			Console.Read();
        }
    }
}
