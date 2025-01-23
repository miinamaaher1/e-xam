using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using BLL.EntityLists;
using DAL;

namespace BLL.EntityManagers
{
    public class CourseManger
    {
        static DBManager dBManager = new DBManager();

        public static CourseList getStudentcourse(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

           
            try
            {
                return datatabletocourses(dBManager.executeDataTable("getStudentCourses", parameters));
            }

            catch (Exception ex) {

                Console.WriteLine($"Error in getStudentcourse: {ex.Message}");
                return new CourseList(); 
            }

          

        }


            internal static CourseList datatabletocourses(DataTable dt)
            {
            CourseList c = new CourseList();
          
                if (dt?.Rows?.Count > 0)
                {
                
                
                foreach(DataRow dr in dt.Rows)
                    {
                        c.Add(datarowtocourses(dr));

                    }
                
                }





            return c;
        }

        internal static Course datarowtocourses(DataRow dataRow)
        {

            Course course = new Course();

            course.id = Convert.ToInt32(dataRow["id"]);
            course.name = Convert.ToString(dataRow["name"]);
            return course;


        }







    }
}

