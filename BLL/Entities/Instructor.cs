using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Instructor : User
    {
        public decimal? salary { get; set; }
        public Department dept { get; set; }

    }
}
