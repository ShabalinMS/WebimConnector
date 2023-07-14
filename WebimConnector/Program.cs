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


			Console.Read();
        }
    }
}
