using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class StudentReport
    {
        public string first_name {  get; set; }
        public string last_name { get; set; }
        public decimal gpa { get; set; }
        public string course_name { get; set; }
        public decimal total_grade { get; set; }
    }
}
