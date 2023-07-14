using System.Linq;
using System;
using WebimConnector.Utils;
using WebimConnector.WebimUtils.Model;
using System.Collections.Generic;
using RestSharp;

namespace WebimConnector.WebimUtils.Import
{
    /// <summary>
    /// Синхронизация операторов
    /// </summary>
    public static class ImportOperatorsHandler
    {
        /// <summary>
        /// Получение всех операторовя
        /// </summary>
        /// <returns></returns>
        public static IReadOnlyList<OperatorModel> GetOperatord()
        {
            RestUtilsWebim help = new RestUtilsWebim();
            OperatorModel[] operators = ConvertJsonHelper.ConvertJsonInModel<OperatorModel[]>((string)help.Execute("/api/v2/operators", Method.Get));

            return operators.ToList();
        }
    }
}
