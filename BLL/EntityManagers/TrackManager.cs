using BLL.Entities;
using BLL.EntityList;
using DAL;
using System.Data;

namespace BLL.EntityManagers
{
    public class TrackManager
    {
        static DBManager dBManager = new DBManager();

        public static Dictionary<string, int> getTrackNamesAndIds(int _instId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@instId", _instId);
            DataTable dt = dBManager.executeDataTable("getTrackNamesAndIds", parameters);
            Dictionary<string, int> trackDictionary = new Dictionary<string, int>();
            foreach (DataRow row in dt.Rows)
            {
                trackDictionary.Add(Convert.ToString(row["name"]), Convert.ToInt32(row["id"]));
            }
            return trackDictionary;
        }


        public static TrackList getInstructorTracksInCrs(int _instId, int _crsId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@instId", _instId);
            parameters.Add("@crsId", _crsId);
            DataTable dt = dBManager.executeDataTable("getInstructorTracksInCrs", parameters);

            TrackList trackList = new TrackList();
            foreach (DataRow dr in dt.Rows)
            {
                trackList.Add(
                    new Track
                    {
                        id = Convert.ToInt32(dr["id"]),
                        name = Convert.ToString(dr["name"])
                    }
                );
            }
            return trackList;

        }
    }
}
