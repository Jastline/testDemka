using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using testDemka.Data;

namespace testDemka
{
    public static class Session
    {
        // Храним текущего пользователя
        public static User CurrentUser { get; set; }

        // Вспомогательные свойства для быстрого доступа
        public static bool IsAdmin => CurrentUser?.isAdmin ?? false;
        public static bool IsManager => CurrentUser?.isManager ?? false;
        public static bool IsClient => CurrentUser?.isClient ?? false;
        public static bool IsGuest => CurrentUser == null || CurrentUser.roleName == "Гость";

        // Метод для выхода
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
