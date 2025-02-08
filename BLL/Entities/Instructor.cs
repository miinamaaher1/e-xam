namespace BLL.Entities
{
    public class Instructor : User
    {
        public decimal? salary { get; set; }
        public Department dept { get; set; }

    }
}
