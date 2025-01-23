using BLL.Entities;
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
    }
}
