namespace BLL.Entities
{
    public class TrackExam
    {
        public int trackId { get; set; }
        public int examId { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}
