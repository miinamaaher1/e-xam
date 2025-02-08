namespace BLL.Entities
{
    public class Answer : Entity
    {
        public int questionId { get; set; }
        public char? answerNum { get; set; }
    }
}
