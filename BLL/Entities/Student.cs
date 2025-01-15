using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Student : User
    {
        public decimal? gpa { get; set; }
        public Track track { get; set; }
        public List<Course> courses { get; set; }
    }
}