using System.Runtime.CompilerServices;

namespace WebimConnector.WebimUtils.Model
{
    /// <summary>
    /// Модель данных оператор
    /// </summary>
    public class OperatorModel
    {
        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// ФИО оператора
        /// </summary>
        public string Full_Name { get; set; }

        /// <summary>
        /// Идунтификатор пользователя
        /// </summary>
        public int Id { get; set; }
    }
}
