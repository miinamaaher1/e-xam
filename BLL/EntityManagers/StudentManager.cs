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

 public static List<Student> getStudentsByTrack(int trackId) // This functions returns specific data about students (not all students' data)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@trackId", trackId);

            DataTable dt = dBManager.executeDataTable("getStudentsByTrack", parameters);
            List<Student> students = new List<Student>();

            foreach (DataRow row in dt.Rows)
            {
                students.Add(new Student
                {
                    firstName = Convert.ToString(row["first_name"]),
                    lastName = Convert.ToString(row["last_name"]),
                    track = new Track
                    {
                        id = Convert.ToInt32(row["track_id"]),
                        name = Convert.ToString(row["track_name"])
                    },
                    gpa = Convert.ToDecimal(row["gpa"])
                });
            }

            return students;
        }
        
        public static Student getStudentStats(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", _id);

            DataTable dt = dBManager.executeDataTable("getStudentStats", parameters);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
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
                        , Convert.ToDecimal(dr["total_grade"])
                    );
                }

                return student;
            }
        }




        public static List<StudentExam> getStudetExams(int _studentid, int _courseid,int _trakid)
        {
            List<StudentExam> exams = new List<StudentExam>();
          
            Dictionary<string, object> parameters = new Dictionary<string, object>
         {
        { "@studentid", _studentid },
        { "@courseid", _courseid },
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
                       courseid  = _courseid,
                        student = new Student { id = _studentid },
                        status = Convert.ToChar(dr["status"])



                    });

                }
                return exams;
            
            

        }
    }  
}
