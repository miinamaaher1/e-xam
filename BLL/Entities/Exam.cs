namespace BLL.Entities
{
    public class Exam : Entity
    {
        public int id { get; set; }
        public string? title { get; set; }
        public int duration { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int totalDegree { get; set; }
        public Course course { get; set; }
        public List<Question> questions { get; set; }


        //////////////////////////////////////////////
        public List<Track> tracks { get; set; }
        /*****/
        public string tracksId { get; set; }
        /*****/
        public int mcqCount { get; set; }
        public int tfCount { get; set; }

        public override string ToString()
        {
            return $"{id} {title}";
        }


    }
}
