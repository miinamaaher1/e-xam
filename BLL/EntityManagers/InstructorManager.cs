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

        public static StudentExam reviewStudentAnswers(int _examId, int _stdId)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@ex_id", _examId);
            parameters.Add("@std_id", _stdId);

            DataTable dt = dBManager.executeDataTable("reviewStudentAnswers", parameters);

            StudentExam stdExam = new StudentExam();

            stdExam.student = new Student
            {
                firstName = Convert.ToString(dt.Rows[0]["first_name"]),
                lastName = Convert.ToString(dt.Rows[0]["last_name"]),
            };

            stdExam.grade = Convert.ToDecimal(dt.Rows[0]["score"]);

            stdExam.exam = new Exam
            {
                questions = new List<Question>()
            };

            // add questions
            HashSet<int> q_ids = new HashSet<int>();
            foreach (DataRow dr in dt.Rows)
            {
                if (q_ids.Contains(Convert.ToInt32(dr["id"])))
                {
                    foreach (Question q in stdExam.exam.questions)
                    {
                        if (q.id == Convert.ToInt32(dr["id"]))
                        {
                            q.options.Add(new Option
                            {
                                num = Convert.ToChar(dr["Option"]),
                                body = Convert.ToString(dr["OptionBody"])
                            });
                            break;
                        }
                    }
                }
                else
                {
                    q_ids.Add(Convert.ToInt32(dr["id"]));
                    Question q = new Question()
                    {
                        id = Convert.ToInt32(dr["id"]),
                        body = Convert.ToString(dr["Question"]),
                        type = Convert.ToChar(dr["type"]),
                        ans = Convert.ToChar(dr["RightAnswer"]),
                        selectedAns = Convert.ToChar(dr["StudentAnswer"])
                    };
                    if (Convert.ToChar(dr["type"]) == 'm') // maybe
                    {
                        q.options = new List<Option>();
                        q.options.Add(new Option
                        {
                            num = Convert.ToChar(dr["Option"]),
                            body = Convert.ToString(dr["OptionBody"])
                        });
                    };
                    stdExam.exam.questions.Add(q);
                }
            }
            
            return stdExam;

        }
    }
}
