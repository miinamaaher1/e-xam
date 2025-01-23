using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{

    public class TrackManager
    {
        static DBManager dBManager = new DBManager();

        public static Dictionary<string, int> getTrackNamesAndIds()
        {
            DataTable dt = dBManager.executeDataTable("getTrackNamesAndIds");
            Dictionary<string, int> trackDictionary = new Dictionary<string, int>();
            foreach(DataRow row in dt.Rows)
            {
                trackDictionary.Add(Convert.ToString(row["name"]) ,Convert.ToInt32(row["id"]));
            }
            return trackDictionary;
        }
    }
}
