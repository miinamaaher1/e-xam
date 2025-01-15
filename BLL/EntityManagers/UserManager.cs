using BLL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{
    public class UserManager
    {
        static DBManager dBManager = new DBManager();
        public static User login(string _userName, string _password)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@username", _userName);
            parameters.Add("@password", _password);

            DataTable dt = dBManager.executeDataTable("login", parameters);

            return new User
            {
                id = Convert.ToInt32(dt.Rows[0]["id"]),
                type = Convert.ToChar(dt.Rows[0]["type"])
            };
        }
    }
}