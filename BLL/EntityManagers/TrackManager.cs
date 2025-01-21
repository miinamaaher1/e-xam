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
    public class TrackManager
    {
        static DBManager dBManager = new DBManager();
        public static TrackList getInstructorTracksInCrs(int _instId , int _crsId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@instId", _instId);
            parameters.Add("@crsId", _crsId);
            DataTable dt = dBManager.executeDataTable("getInstructorTracksInCrs", parameters);

            TrackList trackList = new TrackList();
            foreach (DataRow dr in dt.Rows) {
                trackList.Add(
                    new Track {
                        id = Convert.ToInt32( dr["id"]),
                        name = Convert.ToString( dr["name"] )
                    }
                );
            }
            return trackList;
        }
    }
}
