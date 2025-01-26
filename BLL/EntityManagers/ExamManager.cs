using BLL.Entities;
using BLL.EntityList;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{
    public class ExamManager
    {
        static DBManager dBManager = new DBManager();
        public static int  generateExam(Exam _exam)
        {
            Dictionary<string,object> dict = new Dictionary<string,object>();
            dict.Add("@courseId", _exam.course.id);
            dict.Add("@tfCount", _exam.tfCount);
            dict.Add("@mcqCount", _exam.mcqCount);
            dict.Add("@duration",_exam.duration);
            dict.Add("@title", _exam.title);

            DataTable dt = dBManager.executeDataTable("generateExam", dict);

            return Convert.ToInt32( dt.Rows[0]["id"]);
        }

        public static Exam getExam(int _id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@examId", _id);
            DataTable dt = dBManager.executeDataTable("getExam", parameters);
            Exam exam = new Exam
            {
                id = _id,
                duration = Convert.ToInt32(dt.Rows[0]["duration"]),
                title = Convert.ToString(dt.Rows[0]["title"]),
                questions = new List<Question>()
            };
            // add questions
            HashSet<int> q_ids = new HashSet<int>();
            foreach (DataRow dr in dt.Rows)
            {
                if (q_ids.Contains(Convert.ToInt32(dr["id"])))
                {
                    foreach(Question q in exam.questions)
                    {
                        if (q.id == Convert.ToInt32(dr["id"]))
                        {
                            q.options.Add(new Option
                            {
                                num = Convert.ToChar(dr["num"]),
                                body = Convert.ToString(dr["o_body"])
                            });
                            break;
                        }
                    }
                } else
                {
                    q_ids.Add(Convert.ToInt32(dr["id"]));
                    Question q = new Question()
                    {
                        id = Convert.ToInt32(dr["id"]),
                        body = Convert.ToString(dr["q_body"]),
                        type = Convert.ToChar(dr["type"]),
                    };
                    if (Convert.ToChar(dr["type"]) == 'm')
                    {
                        q.options = new List<Option>();
                        q.options.Add(new Option
                        {
                            num = Convert.ToChar(dr["num"]),
                            body = Convert.ToString(dr["o_body"])
                        });
                    };
                    exam.questions.Add(q);
                }
            }
            return exam;
        }
    }
}
