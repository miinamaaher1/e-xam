using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{
    public class QuestionsManager
    {
        static DBManager dBManager = new DBManager();
        public static void GetTfMcqCount(int _crsId,out int _tfCount  , out int _mcqCount )
        {
            Dictionary<string , object> parameters = new Dictionary<string , object>();
            parameters.Add("@courseId", _crsId);
            DataTable dt = dBManager.executeDataTable("GetTfMcqCount", parameters);
            _tfCount = Convert.ToInt32( dt.Rows[0]["tf"]);
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
