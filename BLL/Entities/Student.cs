namespace BLL.Entities
{
    public class Student : User
    {
        public decimal? gpa { get; set; }
        public Track track { get; set; }
        public override string ToString()
        {
            return $"{id} {firstName} {lastName}";
        }
    }
}