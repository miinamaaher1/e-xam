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

            if (dt.Rows.Count == 0) return null;

            return new Student
            {
                id = Convert.ToInt32(dt.Rows[0]["id"]),
                type = Convert.ToChar(dt.Rows[0]["type"]),
                firstName = Convert.ToString(dt.Rows[0]["first_name"]),
                lastName = Convert.ToString(dt.Rows[0]["last_name"]),
                track = new Track
                {
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

        public static List<TrackStatsRecord> getStudentsByTrack(int trackId) // This functions returns specific data about students (not all students' data)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@trackId", trackId);

            DataTable dt = dBManager.executeDataTable("getStudentsByTrack", parameters);
            List<TrackStatsRecord> trackReport = new List<TrackStatsRecord>();

            foreach (DataRow row in dt.Rows)
            {
                trackReport.Add(new TrackStatsRecord
                {
                    first_name = Convert.ToString(row["first_name"]),
                    last_name = Convert.ToString(row["last_name"]),
                    track_name = Convert.ToString(row["track_name"]),
                    gpa = Convert.ToDecimal(row["gpa"])
                });
            }

            return trackReport;
        }

        public static List<StudentStatsRecord> getStudentStats(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getStudentStats", parameters);

            List<StudentStatsRecord> statsRecords = new List<StudentStatsRecord>();


            if (dt.Rows.Count == 0)
            {
                Student student = getStudent(_id);

                StudentStatsRecord statsRecord = new StudentStatsRecord
                {
                    first_name = student.firstName,
                    last_name = student.lastName,
                    course_name = "",
                    gpa = (decimal)student.gpa,
                    total_grade = 0
                };
                statsRecords.Add(statsRecord);

                return statsRecords;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    StudentStatsRecord statsRecord = new StudentStatsRecord
                    {
                        first_name = Convert.ToString(dr["first_name"]),
                        last_name = Convert.ToString(dt.Rows[0]["last_name"]),
                        course_name = Convert.ToString(dr["course_name"]),
                        gpa = Convert.ToDecimal(dr["gpa"]),
                        total_grade = Convert.ToDecimal(dr["total_grade"] == DBNull.Value ? 0 : dr["total_grade"])
                    };
                    statsRecords.Add(statsRecord);
                }

                return statsRecords;
            }
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
