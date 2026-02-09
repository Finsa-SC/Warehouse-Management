using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHousePro
{
    internal class UserSession
    {
        public static int id {  get; set; }
        public static string username { get; set; }
        public static int roleId{ get; set; }

        public static void Login(int UserId, string Username, int RoleId)
        {
            id = UserId;
            username = Username;
            roleId = RoleId;
        }
        public static void Logout()
        {
            id = 0;
            username = "";
            roleId = 0;
        }
        public static bool IsLoggedIn()
        {
            return id != 0;
        }
    }
}
