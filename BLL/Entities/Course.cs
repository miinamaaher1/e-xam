using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Course : Entity
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<string> topics { get; set; }
        public List<Question> questions { get; set; }
        public List<Student> students { get; set; }
    }
}