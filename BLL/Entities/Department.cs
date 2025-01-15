using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Department : Entity
    {
        public int id { get; set; }
        public string name { get; set; }
        public Instructor? mgr { get; set; }
    }
}
