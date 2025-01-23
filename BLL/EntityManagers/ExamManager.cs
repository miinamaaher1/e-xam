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
            dict.Add("@startDate", _exam.startDate);
            dict.Add("@endDate", _exam.endDate);
            dict.Add("@tfCount", _exam.tfCount);
            dict.Add("@mcqCount", _exam.mcqCount);
            dict.Add("@duration",_exam.duration);
            dict.Add("@title", _exam.title);
            dict.Add("@tracks", _exam.tracksId);

            DataTable dt = dBManager.executeDataTable("generateExam", dict);

            return Convert.ToInt32( dt.Rows[0]["id"]);
        }
    }
}
