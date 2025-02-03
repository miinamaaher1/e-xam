using BLL.Entities;
using DAL;
using System.Data;

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

 public static List<TrackReport> getStudentsByTrack(int trackId) // This functions returns specific data about students (not all students' data)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@trackId", trackId);

            DataTable dt = dBManager.executeDataTable("getStudentsByTrack", parameters);
            List<TrackReport> trackReport = new List<TrackReport>();

            foreach (DataRow row in dt.Rows)
            {
                trackReport.Add(new TrackReport
                {
                    first_name = Convert.ToString(row["first_name"]),
                    last_name = Convert.ToString(row["last_name"]),
                    track_name = Convert.ToString(row["track_name"]),
                    gpa = Convert.ToDecimal(row["gpa"])
                });
            }

            return trackReport;
        }
        
        public static Student getStudentStats(int _id)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            int stud_exist = (int)dBManager.executeScaler("checkStudent", parameters);

            if(stud_exist == 0)
            {
                return null;
            }

            DataTable dt = dBManager.executeDataTable("getStudentStats", parameters);

            Student student = new Student();

            student.firstName = Convert.ToString(dt.Rows[0]["first_name"]);
            student.lastName = Convert.ToString(dt.Rows[0]["last_name"]);
            student.gpa = Convert.ToDecimal(dt.Rows[0]["gpa"]);

            foreach (DataRow dr in dt.Rows)
            {
                if (student.courseGrades == null)
                {
                    student.courseGrades = new();
                }

                student.courseGrades.Add
                (
                    new Course
                    {
                        name = Convert.ToString(dr["course_name"])
                    }
                    , dr["total_grade"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["total_grade"])
                );
            }

            return student;
        }

        public static List<StudentExam> getStudetExams(int _studentid, int _courseid, int _trakid)
        {
            List<StudentExam> exams = new List<StudentExam>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@studentid", _studentid },
                {"@courseid", _courseid },
                {"@trakid",_trakid}
            };

            DataTable dt = dBManager.executeDataTable("getExams", parameters);
            foreach (DataRow dr in dt.Rows)
            {
                exams.Add(new StudentExam
                {
                    exam = new Exam
                    {
                        id = Convert.ToInt32(dr["id"]),
                        title = Convert.ToString(dr["title"]),
                        startDate = Convert.ToDateTime(dr["startDate"]),
                        endDate = Convert.ToDateTime(dr["endDate"])
                    },
                    courseid = _courseid,
                    student = new Student { id = _studentid },
                    status = Convert.ToChar(dr["status"])
                });
            }
            return exams;
        }
        public static List<Exam> getStudentCourseExams(int _crsId, int _stdId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@crs_id", _crsId);
            parameters.Add("@std_id", _stdId);

            DataTable dt = dBManager.executeDataTable("getStudentCourseExams", parameters);

            List<Exam> exams = new List<Exam>();

            foreach (DataRow dr in dt.Rows)
            {
                exams.Add
                (
                    new Exam
                    {
                       id = Convert.ToInt32(dr["id"]),
                       title = Convert.ToString(dr["title"]),
                    }
                );
            }
            return exams;
        }
    }  
}
