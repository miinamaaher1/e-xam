using BLL.Entities;
using BLL.EntityList;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{
    public class StudentManager
    {
        static DBManager dBManager = new DBManager();
        public static Student getStudent(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getStudent", parameters);

            return new Student
            {
                id = Convert.ToInt32(dt.Rows[0]["id"]),
                type = Convert.ToChar(dt.Rows[0]["type"]),
                firstName = Convert.ToString(dt.Rows[0]["first_name"]),
                lastName = Convert.ToString(dt.Rows[0]["last_name"]),
                track = new Track { 
                    id = Convert.ToInt32(dt.Rows[0]["track_id"]),
                    name = Convert.ToString(dt.Rows[0]["track_name"]),
                    dept = new Department
                    {
                        id = Convert.ToInt32(dt.Rows[0]["dept_id"]),
                        name = Convert.ToString(dt.Rows[0]["dept_name"])
                    }
                },
                gpa = Convert.ToDecimal(dt.Rows[0]["gpa"])
            };
        }





    }  
}
