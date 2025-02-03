using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ReviewAnswer
    {
        public string first_name { get; set; }

        public string last_name { get; set; }

        public decimal? score { get; set; }
        public string Question { get; set; }
        public char Option { get; set; }
        public string OptionBody { get; set; }
        public char StudentAnswer { get; set; }
        public char RightAnswer { get; set; }
    }
}
