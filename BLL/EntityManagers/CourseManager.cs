using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System.Data;

namespace BLL.EntityManagers
{
    public class CourseManager
    {
        static DBManager dBManager = new DBManager();

        public static CourseList getInstructorCourses(int _instId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@instId", _instId);
            DataTable dt = dBManager.executeDataTable("getInstructorCourses", parameters);
            return dataTableToCourseList(dt);

        }

        static public DataTable getCourseTopics(int _courseId)
        {
            List<string> topics = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@crsId", _courseId);

            DataTable dt = dBManager.executeDataTable("getCourseTopics", parameters);
            return dt;
        }

        public static CourseList getStudentCourses(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);


            try
            {
                return dataTableToCourseList(dBManager.executeDataTable("getStudentCourses", parameters));
            }

            catch (Exception ex)
            {

                Console.WriteLine($"Error in getStudentcourse: {ex.Message}");
                return new CourseList();
            }
        }

        internal static CourseList dataTableToCourseList(DataTable dt)
        {
            CourseList c = new CourseList();

            if (dt?.Rows?.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    c.Add(dataRowToCourse(dr));
                }
            }
            return c;
        }

        internal static Course dataRowToCourse(DataRow dataRow)
        {
            Course course = new Course();
            course.id = Convert.ToInt32(dataRow["id"]);
            course.name = Convert.ToString(dataRow["name"]);
            return course;
        }

        public static Dictionary<string, int> getCoursesByInstId(int inst_id)
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
