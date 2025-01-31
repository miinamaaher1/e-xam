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
    }
}
