using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Entities;
using DAL;

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
    }
}
