using BLL.Entities;
using DAL;
using System.Data;

namespace BLL.EntityManagers
{
    public class AnswerManager
    {
        private static DBManager dBManager = new DBManager();
        public static double submitAnswers(int _examId, int _studentId, List<Answer> _answers)
        {
            DataTable dt = convertAnswerListToDataTable(_answers);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@studentId", _studentId);
            parameters.Add("@examId", _examId);
            parameters.Add("@answers", dt);
            dBManager.executeNonQuery("submitAnswers", parameters);
            parameters.Remove("@answers");
            return (double)dBManager.executeScaler("getExamResult", parameters);
        }

        static DataTable convertAnswerListToDataTable(List<Answer> list)
        {
            // Create a new DataTable
            DataTable table = new DataTable();

            // Add columns
            table.Columns.Add("questionId", typeof(int));
            table.Columns.Add("answerNum", typeof(char));

            // Add rows from the list
            foreach (Answer answer in list)
            {
                table.Rows.Add(answer.questionId, answer.answerNum);
            }

            return table;
        }

        public static List<ReviewAnswers> reviewStudentAnswers(int _examId, int _stdId, char _type)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@ex_id", _examId);
            parameters.Add("@std_id", _stdId);

            DataTable dt = dBManager.executeDataTable("reviewStudentAnswers", parameters);

            List<ReviewAnswers> answerSheet = new List<ReviewAnswers>();

            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToChar(dr["QuestionType"]) == _type)
                {
                    ReviewAnswers answer = new ReviewAnswers
                    {
                        FirstName = Convert.ToString(dr["FirstName"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        Score = Convert.ToDecimal(dr["Score"] == DBNull.Value ? 0 : dr["Score"]),
                        QuestionBody = Convert.ToString(dr["QuestionBody"]),
                        OptionNum = Convert.ToChar(dr["OptionNum"] == DBNull.Value ? '\0' : dr["OptionNum"]),
                        OptionBody = Convert.ToString(dr["OptionBody"] == DBNull.Value ? "\0" : dr["OptionBody"]),
                        StudentAnswer = Convert.ToChar(dr["StudentAnswer"] == DBNull.Value ? '\0' : dr["StudentAnswer"]),
                        ModelAnswer = Convert.ToChar(dr["ModelAnswer"])
                    };
                    answerSheet.Add(answer);
                }
            }
            return answerSheet;
        }
    }
}
