namespace BLL.Entities
{
    public class CourseInstructorTrack : Entity
    {
        public Course course { get; set; }
        public Instructor? instructor { get; set; }
        public Track track { get; set; }
        public DateOnly? startDate { get; set; }
        public DateOnly? endDate { get; set; }
        public int studentCount { get; set; }

        public override string ToString()
        {
            return $"{track.name} / {course.name}";
        }
    }
}
