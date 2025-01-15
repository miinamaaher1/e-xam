using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AnswerSheet : Entity
    {
        public Student student { get; set; }
        public Exam exam { get; set; }
        public Dictionary<Question, char?> answers { get; set; }
    }
}
