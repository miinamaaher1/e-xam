namespace BLL.Entities
{
    public class ReviewAnswers
    {
        public string QuestionBody { get; set; }
        public char QuestionType { get; set; }
        public char OptionNum { get; set; }
        public string OptionBody { get; set; }
        public char StudentAnswer { get; set; }
        public decimal Score { get; set; }
        public char ModelAnswer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
