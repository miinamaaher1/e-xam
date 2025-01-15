using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class StudentExam : Entity
    {
        public Student student { get; set; }
        public Exam exam { get; set; }
        public int? grade { get; set; }
        public char? status { get; set; }
    }
}
