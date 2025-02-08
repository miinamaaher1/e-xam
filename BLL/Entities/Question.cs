namespace BLL.Entities
{
    public class Question : Entity
    {
        public int id { get; set; }
        public string body { get; set; }
        public List<Option> options { get; set; }
        public char ans { get; set; }

        public char selectedAns { get; set; }
        public int mark { get; set; }
        public char type { get; set; }
        public Course course { get; set; }
        private List<Exam> exams { get; set; }
    }
}
