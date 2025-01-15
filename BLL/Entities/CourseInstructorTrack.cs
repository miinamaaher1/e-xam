using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class CourseInstructorTrack : Entity
    {
        public Course course { get; set; }
        public Instructor? instructor { get; set; }
        public Track track { get; set; }
        public DateOnly? startDate { get; set; }
        public DateOnly? endDate { get; set; }
    }
}
