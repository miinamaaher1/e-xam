using BLL.Entities;
using DAL;
using System.Data;

namespace BLL.EntityManagers
{
    public class QuestionManager
    {
        static DBManager dBManager = new DBManager();

        public static void addTFQuestion(Question question)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@body", question.body);
            dict.Add("@mark", question.mark);
            dict.Add("@type", question.type);
            dict.Add("@ans", question.ans);
            dict.Add("@crs_id", question.course.id);

            DataTable dt = dBManager.executeDataTable("addTFQuestion", dict);

            //return Convert.ToInt32(dt.Rows[0]["id"]);
        }

        public static void addMCQQuestion(Question question)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@body", question.body);
            dict.Add("@mark", question.mark);
            dict.Add("@type", question.type);
            dict.Add("@ans", question.ans);
            dict.Add("@crs_id", question.course.id);
            dict.Add("@optionA", question.options[0].body);
            dict.Add("@optionB", question.options[1].body);
            dict.Add("@optionC", question.options[2].body);
            dict.Add("@optionD", question.options[3].body);
            DataTable dt = dBManager.executeDataTable("addMCQQuestion", dict);

            //return Convert.ToInt32(dt.Rows[0]["id"]);
        }

        public static void GetTfMcqCount(int _crsId, out int _tfCount, out int _mcqCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@courseId", _crsId);
            DataTable dt = dBManager.executeDataTable("GetTfMcqCount", parameters);
            _tfCount = Convert.ToInt32(dt.Rows[0]["tf"]);
            _mcqCount = Convert.ToInt32(dt.Rows[0]["mcq"]);
        }
        public static DataTable getExamMcqQuestions(int _examId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@examId", _examId);
            DataTable dt = dBManager.executeDataTable("getExamMcqQuestions", parameters);
            return dt.Copy();
        }
        public static DataTable getExamTfQuestions(int _examId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@examId", _examId);
            DataTable dt = dBManager.executeDataTable("getExamTfQuestions", parameters);
            return dt.Copy();
        }
    }
}
