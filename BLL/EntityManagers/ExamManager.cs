using BLL.Entities;
using BLL.EntityList;
using DAL;
using System.Data;

namespace BLL.EntityManagers
{
    public class ExamManager
    {
        static DBManager dBManager = new DBManager();
        public static int generateExam(Exam _exam)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@courseId", _exam.course.id);
            dict.Add("@tfCount", _exam.tfCount);
            dict.Add("@mcqCount", _exam.mcqCount);
            dict.Add("@duration", _exam.duration);
            dict.Add("@title", _exam.title);

            int examId = (int)(dBManager.executeScaler("generateExam", dict));

            return examId;
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
                    foreach (Question q in exam.questions)
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
                }
                else
                {
                    q_ids.Add(Convert.ToInt32(dr["id"]));
                    Question q = new Question()
                    {
                        id = Convert.ToInt32(dr["id"]),
                        body = Convert.ToString(dr["q_body"]),
                        type = Convert.ToChar(dr["type"]),
                    };
                    if (Convert.ToChar(dr["type"]) == 'm') // maybe
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

        public static int assignExamToTracks(int examId, DateTime startDate, DateTime endDate, TrackList tracks)
        {
            DataTable tracksDt = new DataTable();

            tracksDt.Columns.Add("Id", typeof(int));

            foreach (var track in tracks)
                tracksDt.Rows.Add(track.id);

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@examId", examId);
            parameters.Add("@startDate", startDate);
            parameters.Add("@endDate", endDate);
            parameters.Add("@tracks", tracksDt);

            return (int)(dBManager.executeScaler("assignExamToTracks", parameters));

        }
        public static int generateAnotherExamQ(Exam _exam)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@examId", _exam.id);
            dict.Add("@courseId", _exam.course.id);
            dict.Add("@tfCount", _exam.tfCount);
            dict.Add("@mcqCount", _exam.mcqCount);
            return (int)(dBManager.executeScaler("generateAnotherExamQ", dict));
        }
        public static void getExamCourseTitle(int _examId, out string _crsName, out string _examTile, out int _duration)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@examId", _examId);
            DataTable dt = dBManager.executeDataTable("getExamCourseTitle", dict);

            _examTile = Convert.ToString(dt.Rows[0]["title"]);
            _crsName = Convert.ToString(dt.Rows[0]["name"]);
            _duration = Convert.ToInt32(dt.Rows[0]["duration"]);

        }
        public static List<int> GetExamsIdByCrsId(int _courseId)
        {
            List<int> examsId = new List<int>();

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@courseId", _courseId);
            DataTable dt = dBManager.executeDataTable("GetExamsIdByCrsId", dict);

            foreach (DataRow dr in dt.Rows)
                examsId.Add(Convert.ToInt32(dr["id"]));

            return examsId;
        }
    }
}
