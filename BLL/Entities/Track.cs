using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Track : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public Department dept { get; set; }
    }
}
