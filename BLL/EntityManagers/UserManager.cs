using BLL.Entities;
using DAL;
using System.Data;

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

        public static User getUser(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getUser", parameters);

            return new User
            {
                id = Convert.ToInt32(dt.Rows[0]["id"]),
                firstName = Convert.ToString(dt.Rows[0]["first_name"]),
                lastName = Convert.ToString(dt.Rows[0]["last_name"]),
                userName = Convert.ToString(dt.Rows[0]["user_name"]),
                ssn = Convert.ToString(dt.Rows[0]["ssn"]),
                gender = Convert.ToChar(dt.Rows[0]["gender"]),
            };
        }

        public static int updateUserName(int _id, string _newUserName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);
            parameters.Add("@newUserName", _newUserName);
            return dBManager.executeNonQuery("updateUserName", parameters);
        }
        public static int updateFirstName(int _id, string _newFirstName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);
            parameters.Add("@newFirstName", _newFirstName);
            return dBManager.executeNonQuery("updateFirstName", parameters);
        }
        public static int updateLastName(int _id, string _newLastName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);
            parameters.Add("@newLastName", _newLastName);
            return dBManager.executeNonQuery("updateLastName", parameters);
        }
        public static int updateGender(int _id, char _newGender)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);
            parameters.Add("@newGender", _newGender);
            return dBManager.executeNonQuery("updateGender", parameters);
        }
        public static int updateSSN(int _id, string _newSSN)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);
            parameters.Add("@newSSN", _newSSN);
            return dBManager.executeNonQuery("updateSSN", parameters);
        }
        public static int updatePassword(int _id, string _oldPassword, string _newPassword)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);
            parameters.Add("@oldPassword", _oldPassword);
            parameters.Add("@newPassword", _newPassword);
            return dBManager.executeNonQuery("updatePassword", parameters);
        }
    }
}