using BLL.Entities;
using DAL;
using System.Data;

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

        public static List<CourseInstructorTrack> getInstructorClasses(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getInstructorClasses", parameters);

            List<CourseInstructorTrack> crsInsTrk = new List<CourseInstructorTrack>();

            foreach (DataRow dr in dt.Rows)
            {
                crsInsTrk.Add
                (
                    new CourseInstructorTrack
                    {
                        course = new Course
                        {
                            id = Convert.ToInt32(dr["course_id"]),
                            name = Convert.ToString(dr["course_name"])
                        },

                        track = new Track
                        {
                            id = Convert.ToInt32(dr["track_id"]),
                            name = Convert.ToString(dr["track_name"])
                        },

                        studentCount = Convert.ToInt32(dr["student_numbers"])
                    }
                );
            }

            return crsInsTrk;

        }

        public static List<Student> getTrackStudents(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getTrackStudents", parameters);

            List<Student> studentList = new List<Student>();

            foreach (DataRow dr in dt.Rows)
            {
                studentList.Add
                (
                    new Student
                    {
                        id = Convert.ToInt32(dr["id"]),

                        firstName = Convert.ToString(dr["first_name"]),

                        lastName = Convert.ToString(dr["last_name"])
                    }
                );
            }

            return studentList;
        }
    }
}
