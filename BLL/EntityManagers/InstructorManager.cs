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
    public class InstructorManager
    {
        static DBManager dBManager = new DBManager();
        public static Instructor getInstructor(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getInstructor", parameters);

            return new Instructor
            {
                id = Convert.ToInt32(dt.Rows[0]["id"]),
                type = Convert.ToChar(dt.Rows[0]["type"]),
                firstName = Convert.ToString(dt.Rows[0]["first_name"]),
                lastName = Convert.ToString(dt.Rows[0]["last_name"]),
                dept = new Department
                {
                    id = Convert.ToInt32(dt.Rows[0]["dept_id"]),
                    name = Convert.ToString(dt.Rows[0]["dept_name"])
                }
            };
        }
    }
}
