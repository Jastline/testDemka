using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDemka.Data
{
    public class User
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string roleName { get; set; }

        // Вычисляемые свойства
        public string fullName => $"{lastName} {firstName} {secondName}".Trim();

        // Проверки ролей
        public bool isAdmin => roleName == "Администратор";
        public bool isManager => roleName == "Менеджер";
        public bool isClient => roleName == "Авторизированный клиент";
        public bool isGuest => roleName == "Гость";

        // Статический метод для создания из DataRow
        public static User FromDataRow(DataRow row)
        {
            return new User
            {
                id = Convert.ToInt32(row["id"]),
                firstName = row["firstName"].ToString(),
                secondName = row["secondName"]?.ToString(),
                lastName = row["lastName"].ToString(),
                login = row["login"].ToString(),
                password = row["password"].ToString(),
                roleName = row.Table.Columns.Contains("role_name")
                    ? row["role_name"]?.ToString()
                    : "Гость"
            };
        }
    }
}
