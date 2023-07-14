using RestSharp;
using System.Collections.Generic;
using System.Linq;
using WebimConnector.Utils;
using WebimConnector.WebimUtils.Model;

namespace WebimConnector.WebimUtils.Import
{
	/// <summary>
	/// Хандрел по работе с департаментами
	/// </summary>
	public class ImportDepartmentHandler
	{
		/// <summary>
		/// Получение всех отделов
		/// </summary>
		/// <returns>Список отделов</returns>
		public static IReadOnlyList<DepartmentModel> GetDepartments()
		{
			RestUtilsWebim help = new RestUtilsWebim();
			DepartmentModel[] operators = ConvertJsonHelper.ConvertJsonInModel<DepartmentModel[]>((string)help.Execute("/api/v2/departments", Method.Get));

			return operators.ToList();
		}
	}
}
