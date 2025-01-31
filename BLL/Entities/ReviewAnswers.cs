using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ReviewAnswers
    {
        public string Question { get; set; }
        public char Option { get; set; }

        public string OptionBody { get; set; }
        public char StudentAnswer { get; set; }

        public char RightAnswer { get; set; }
    }
}
