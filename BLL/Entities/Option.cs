using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Option : Entity
    {
        public char? num { get; set; }
        public string? body { get; set; }
        public Question question { get; set; }
    }
}
