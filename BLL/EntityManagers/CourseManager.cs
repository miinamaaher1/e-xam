using BLL.Entities;
using BLL.EntityList;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{
    public class CourseManager
    {
        static DBManager dBManager = new DBManager();

        public static CourseList getInstructorCourses(int _instId)
        {
            Dictionary<string,object> parameters = new Dictionary<string,object>();
            parameters.Add("@instId", _instId);
            DataTable dt = dBManager.executeDataTable("getInstructorCourses", parameters);
            return dataTabelToCourseList(dt);

        }
        public static CourseList dataTabelToCourseList(DataTable _dt)
        {
            CourseList courses = new CourseList();
            foreach (DataRow dr in _dt.Rows) { 
                courses.Add(dataRowToCourse(dr));
            }
            return courses;
        }
        public static Course dataRowToCourse(DataRow _dr) {
            return new Course()
            {
                id = Convert.ToInt32(_dr["id"]),
                name = Convert.ToString(_dr["name"])
            };
        }

        public static Dictionary<string,int> getCoursesByInstId(int inst_id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@instId", inst_id);
            DataTable dt = dBManager.executeDataTable("getCoursesByInstId", parameters);
            Dictionary<string, int> courseDictionary = new Dictionary<string, int>();
            foreach (DataRow row in dt.Rows)
            {
                courseDictionary.Add(Convert.ToString(row["name"]), Convert.ToInt32(row["id"]));
            }
            return courseDictionary;
        }
    }
}
